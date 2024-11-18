using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTRA_1811
{
    public partial class TypeOfCert : Form
    {
        public TypeOfCert()
        {
            InitializeComponent();
            loadCertScreen();
            loadCbbCert();
        }

        int? selectedId = null;

        private void loadCertScreen()
        {
            dgv_cert_load.DataSource = Database.Query(
                "SELECT LoaiChungChi.MaLoaiChungChi, TenLoaiChungChi, LoaiChungChi.MaNgonNgu, ThoiHan FROM LoaiChungChi INNER JOIN NgonNgu ON LoaiChungChi.MaNgonNgu = NgonNgu.MaNgonNgu "
            );
        }

        private void loadCbbCert()
        {
            cbb_cert_id.DisplayMember = "TenNgonNgu";
            cbb_cert_id.ValueMember = "MaNgonNgu";
            cbb_cert_id.DataSource = Database.Query("SELECT * FROM NgonNgu");
        }

        private void btn_cert_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_cert_name.Text))
            {
                MessageBox.Show(
                    "Certificate name cannot be empty.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (txt_cert_name.Text.Length > 30)
            {
                MessageBox.Show(
                    "Certificate name must not exceed 30 characters.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Validate selected language ID
            if (cbb_cert_id.SelectedValue == null)
            {
                MessageBox.Show(
                    "Please select a valid language.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Validate certificate duration
            if (!int.TryParse(txt_cert_value.Text, out int duration) || duration <= 0)
            {
                MessageBox.Show(
                    "Certificate duration must be a positive number.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            //check không trùng tên chứng chỉ, không sử dụng Database.Query

            DataTable dt = Database.Query(
                "SELECT * FROM LoaiChungChi WHERE TenLoaiChungChi = '" + txt_cert_name.Text + "'"
            );
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show(
                    "Certificate name already exists.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            Database.Execute(
                "INSERT INTO LoaiChungChi VALUES(@tenchungchi, @manngonngu, @thoihan)",
                new Dictionary<string, object>()
                {
                    { "@tenchungchi", txt_cert_name.Text },
                    { "@manngonngu", cbb_cert_id.SelectedValue },
                    { "@thoihan", txt_cert_value.Text },
                }
            );
            loadCertScreen();
        }

        private void btn_cert_update_Click(object sender, EventArgs e)
        {
            if (dgv_cert_load.SelectedCells.Count > 0 && selectedId != null)
            {
                Database.Execute(
                    "UPDATE LoaiChungChi SET TenLoaiChungChi = @tenchungchi, MaNgonNgu = @manngonngu, ThoiHan = @thoihan WHERE MaLoaiChungChi = @maloaichungchi",
                    new Dictionary<string, object>()
                    {
                        { "@tenchungchi", txt_cert_name.Text },
                        { "@manngonngu", cbb_cert_id.SelectedValue },
                        { "@thoihan", txt_cert_value.Text },
                        { "@maloaichungchi", selectedId },
                    }
                );

                loadCertScreen();

                MessageBox.Show(
                    "Cập nhật thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    "Vui lòng chọn một loại chứng chỉ để cập nhật!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void dgv_cert_load_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedId = Convert.ToInt32(dgv_cert_load.Rows[e.RowIndex].Cells[0].Value);
            txt_cert_name.Text = dgv_cert_load.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbb_cert_id.SelectedValue = dgv_cert_load.Rows[e.RowIndex].Cells[2].Value;
            txt_cert_value.Text = dgv_cert_load.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void dgv_cert_load_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedId = int.Parse(dgv_cert_load.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_cert_name.Text = dgv_cert_load.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbb_cert_id.SelectedValue = dgv_cert_load.Rows[e.RowIndex].Cells[2].Value;
            txt_cert_value.Text = dgv_cert_load.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btn_cert_delete_Click(object sender, EventArgs e)
        {
            if (selectedId != null)
            {
                DialogResult confirm = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa loại chứng chỉ này và tất cả dữ liệu liên quan?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm == DialogResult.Yes)
                {
                    Database.Execute(
                        "DELETE FROM ChungChi WHERE MaLoaiChungChi = @maloaichungchi",
                        new Dictionary<string, object>() { { "@maloaichungchi", selectedId } }
                    );

                    Database.Execute(
                        "DELETE FROM LoaiChungChi WHERE MaLoaiChungChi = @maloaichungchi",
                        new Dictionary<string, object>() { { "@maloaichungchi", selectedId } }
                    );

                    loadCertScreen();

                    MessageBox.Show(
                        "Xóa thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            else
            {
                MessageBox.Show(
                    "Vui lòng chọn một loại chứng chỉ để xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
    }
}
