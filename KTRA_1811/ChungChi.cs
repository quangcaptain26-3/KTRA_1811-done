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
    public partial class ChungChi : Form
    {
        public ChungChi()
        {
            InitializeComponent();
            loadCertManageScreen();
            loadCbbCertID();
            loadCbbEmployeeID();
        }

        int? selectedId = null;

        private void loadCertManageScreen()
        {
            dgv_manage_cert.DataSource = Database.Query(
                "SELECT ChungChi.MaChungChi, ChungChi.MaLoaiChungChi, ChungChi.MaNhanVien, NgayCap, NoiCap FROM ChungChi INNER JOIN LoaiChungChi ON ChungChi.MaLoaiChungChi = LoaiChungChi.MaLoaiChungChi INNER JOIN NhanVien ON ChungChi.MaNhanVien = NhanVien.MaNhanVien"
            );
        }

        private void loadCbbCertID()
        {
            cbb_for_cert_id.DisplayMember = "TenLoaiChungChi";
            cbb_for_cert_id.ValueMember = "MaLoaiChungChi";
            cbb_for_cert_id.DataSource = Database.Query("SELECT * FROM LoaiChungChi");
        }

        private void loadCbbEmployeeID()
        {
            cbb_for_employee_id.DisplayMember = "HoTen";
            cbb_for_employee_id.ValueMember = "MaNhanVien";
            cbb_for_employee_id.DataSource = Database.Query("SELECT * FROM NhanVien");
        }

        private void btn_add_cert_Click(object sender, EventArgs e)
        {
            if (dtp_for_cert.Value > DateTime.Now)
            {
                MessageBox.Show(
                    "Certificate date must not exceed current date.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_placeof_cert.Text))
            {
                MessageBox.Show(
                    "Place of certificate cannot be empty.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            Database.Execute(
                "INSERT INTO ChungChi (MaLoaiChungChi, MaNhanVien, NgayCap, NoiCap) VALUES (@0, @1, @2, @3)",
                new Dictionary<string, object>()
                {
                    { "0", cbb_for_cert_id.SelectedValue },
                    { "1", cbb_for_employee_id.SelectedValue },
                    { "2", dtp_for_cert.Value },
                    { "3", txt_placeof_cert.Text },
                }
            );
            loadCertManageScreen();
        }

        private void dgv_manage_cert_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedId = Convert.ToInt32(dgv_manage_cert.Rows[e.RowIndex].Cells[0].Value);
            cbb_for_cert_id.SelectedValue = dgv_manage_cert.Rows[e.RowIndex].Cells[1].Value;
            cbb_for_employee_id.SelectedValue = dgv_manage_cert.Rows[e.RowIndex].Cells[2].Value;
            dtp_for_cert.Value = Convert.ToDateTime(
                dgv_manage_cert.Rows[e.RowIndex].Cells[3].Value
            );
            txt_placeof_cert.Text = dgv_manage_cert.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void dgv_manage_cert_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedId = Convert.ToInt32(dgv_manage_cert.Rows[e.RowIndex].Cells[0].Value);
            cbb_for_cert_id.SelectedValue = dgv_manage_cert.Rows[e.RowIndex].Cells[1].Value;
            cbb_for_employee_id.SelectedValue = dgv_manage_cert.Rows[e.RowIndex].Cells[2].Value;
            dtp_for_cert.Value = Convert.ToDateTime(
                dgv_manage_cert.Rows[e.RowIndex].Cells[3].Value
            );
            txt_placeof_cert.Text = dgv_manage_cert.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btn_update_cert_Click(object sender, EventArgs e)
        {
            if (dgv_manage_cert.SelectedCells.Count > 0 && selectedId != null)
            {
                Database.Execute(
                    "UPDATE ChungChi SET MaLoaiChungChi = @0, MaNhanVien = @1, NgayCap = @2, NoiCap = @3 WHERE MaChungChi = @4",
                    new Dictionary<string, object>()
                    {
                        { "0", cbb_for_cert_id.SelectedValue },
                        { "1", cbb_for_employee_id.SelectedValue },
                        { "2", dtp_for_cert.Value },
                        { "3", txt_placeof_cert.Text },
                        { "4", selectedId },
                    }
                );
                loadCertManageScreen();

                MessageBox.Show(
                    "Certificate updated successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    "Please select a certificate to update.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void btn_delete_cert_Click(object sender, EventArgs e)
        {
            if (selectedId != null)
            {
                DialogResult confirm = MessageBox.Show(
                    "Are you sure you want to delete this certificate?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm == DialogResult.Yes)
                {
                    Database.Execute(
                        "DELETE FROM ChungChi WHERE MaChungChi = @0",
                        new Dictionary<string, object>() { { "0", selectedId } }
                    );
                    loadCertManageScreen();

                    MessageBox.Show(
                        "Certificate deleted successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            else
            {
                MessageBox.Show(
                    "Please select a certificate to delete.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
    }
}
