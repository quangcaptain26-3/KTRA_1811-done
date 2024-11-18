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
    public partial class PhongBan : Form
    {
        public PhongBan()
        {
            InitializeComponent();
            loadDepartmentScreen();
        }

        //selectedId là chuỗi chứ không phải số
        string selectedId = null;

        private void loadDepartmentScreen()
        {
            dgv_department_load.DataSource = Database.Query("SELECT * FROM PhongBan");
        }

        private void btn_department_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_department_id.Text))
            {
                MessageBox.Show(
                    "Department ID cannot be empty.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (txt_department_id.Text.Length > 2)
            {
                MessageBox.Show(
                    "Department ID must not exceed 2 characters.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_department_name.Text))
            {
                MessageBox.Show(
                    "Department name cannot be empty.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (txt_department_name.Text.Length > 30)
            {
                MessageBox.Show(
                    "Department name must not exceed 30 characters.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            //check không trùng mã phòng ban
            DataTable dt = Database.Query(
                "SELECT * FROM PhongBan WHERE MaPhongBan = '" + txt_department_id.Text + "'"
            );
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show(
                    "Department ID already exists.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            //check không trùng tên phòng ban
            DataTable dt1 = Database.Query(
                "SELECT * FROM PhongBan WHERE TenPhongBan = '" + txt_department_name.Text + "'"
            );
            if (dt1.Rows.Count > 0)
            {
                MessageBox.Show(
                    "Department name already exists.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            Database.Query(
                "INSERT INTO PhongBan (MaPhongBan, TenPhongBan) VALUES ('"
                    + txt_department_id.Text
                    + "', N'"
                    + txt_department_name.Text
                    + "')"
            );
            loadDepartmentScreen();
        }

        private void btn_department_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_department_id.Text))
            {
                MessageBox.Show(
                    "Department ID cannot be empty.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (txt_department_id.Text.Length > 2)
            {
                MessageBox.Show(
                    "Department ID must not exceed 2 characters.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_department_name.Text))
            {
                MessageBox.Show(
                    "Department name cannot be empty.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (txt_department_name.Text.Length > 30)
            {
                MessageBox.Show(
                    "Department name must not exceed 30 characters.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (selectedId == null)
            {
                MessageBox.Show(
                    "No department selected to update.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DataTable dt = Database.Query(
                "SELECT * FROM PhongBan WHERE TenPhongBan = N'"
                    + txt_department_name.Text
                    + "' AND MaPhongBan != '"
                    + txt_department_id.Text
                    + "'"
            );
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show(
                    "Department name already exists.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            Database.Query(
                "UPDATE PhongBan SET TenPhongBan = N'"
                    + txt_department_name.Text
                    + "' WHERE MaPhongBan = '"
                    + txt_department_id.Text
                    + "'"
            );

            loadDepartmentScreen();
            MessageBox.Show(
                "Department updated successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void dgv_department_load_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e
        )
        {
            if (e.RowIndex >= 0)
            {
                selectedId = dgv_department_load.Rows[e.RowIndex].Cells[0].Value.ToString();

                txt_department_name.Text = dgv_department_load
                    .Rows[e.RowIndex]
                    .Cells[1]
                    .Value.ToString();

                txt_department_id.Text = selectedId;
            }
        }

        private void dgv_department_load_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedId = dgv_department_load.Rows[e.RowIndex].Cells[0].Value.ToString();

                txt_department_id.Text = selectedId;
                txt_department_name.Text = dgv_department_load
                    .Rows[e.RowIndex]
                    .Cells[1]
                    .Value.ToString();
            }
        }

        private void btn_department_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(selectedId))
            {
                MessageBox.Show(
                    "No department selected to delete.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this department and all related employees and certifications?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
     
                    DataTable employees = Database.Query(
                        "SELECT MaNhanVien FROM NhanVien WHERE MaPhongBan = '" + selectedId + "'"
                    );

                    foreach (DataRow row in employees.Rows)
                    {
                        string maNhanVien = row["MaNhanVien"].ToString();
                        Database.Query("DELETE FROM ChungChi WHERE MaNhanVien = " + maNhanVien);
                    }

                    Database.Query("DELETE FROM NhanVien WHERE MaPhongBan = '" + selectedId + "'");

                    Database.Query("DELETE FROM PhongBan WHERE MaPhongBan = '" + selectedId + "'");

                    loadDepartmentScreen();
                    MessageBox.Show(
                        "Department, related employees, and certifications deleted successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "An error occurred while deleting the department: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }
    }
}
