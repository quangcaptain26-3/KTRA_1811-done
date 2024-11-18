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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
            loadEmployeeScreen();
            loadCbbEmployee();
        }

        int? selectedId = null;

        private void loadEmployeeScreen()
        {
            dgv_employee_load.DataSource = Database.Query(
                "SELECT NhanVien.MaNhanVien, HoTen, NgaySinh, NhanVien.MaPhongBan FROM NhanVien INNER JOIN PhongBan ON NhanVien.MaPhongBan = PhongBan.MaPhongBan"
            );
        }

        private void loadCbbEmployee()
        {
            cbbDepartment.DisplayMember = "TenPhongBan";
            cbbDepartment.ValueMember = "MaPhongBan";
            cbbDepartment.DataSource = Database.Query("SELECT * FROM PhongBan");
        }

        private void btn_employee_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_employee_name.Text))
            {
                MessageBox.Show(
                    "Employee name cannot be empty.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (txt_employee_name.Text.Length > 30)
            {
                MessageBox.Show(
                    "Employee name must not exceed 30 characters.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (dtp_for_employee.Value > DateTime.Now)
            {
                MessageBox.Show(
                    "Employee's birth date cannot be in the future.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (cbbDepartment.SelectedValue == null)
            {
                MessageBox.Show(
                    "Please select a valid department.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DataTable dt = Database.Query(
                "SELECT * FROM NhanVien WHERE HoTen = '" + txt_employee_name.Text + "'"
            );
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show(
                    "Employee name already exists.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            Database.Execute(
                "INSERT INTO NhanVien (HoTen, NgaySinh, MaPhongBan) VALUES (@name, @dob, @department)",
                new Dictionary<string, object>
                {
                    { "@name", txt_employee_name.Text },
                    { "@dob", dtp_for_employee.Value },
                    { "@department", cbbDepartment.SelectedValue },
                }
            );
            loadEmployeeScreen();
        }

        private void btn_employee_update_Click(object sender, EventArgs e)
        {
            if (dgv_employee_load.SelectedCells.Count > 0 && selectedId != null)
            {
                Database.Execute(
                    "UPDATE NhanVien SET HoTen = @name, NgaySinh = @dob, MaPhongBan = @department WHERE MaNhanVien = @manhanvien",
                    new Dictionary<string, object>
                    {
                        { "@name", txt_employee_name.Text },
                        { "@dob", dtp_for_employee.Value },
                        { "@department", cbbDepartment.SelectedValue },
                        { "@manhanvien", selectedId },
                    }
                );
                loadEmployeeScreen();

                MessageBox.Show(
                    "Employee updated successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    "No employee selected to update.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void dgv_employee_load_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedId = int.Parse(dgv_employee_load.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_employee_name.Text = dgv_employee_load.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtp_for_employee.Value = DateTime.Parse(
                dgv_employee_load.Rows[e.RowIndex].Cells[2].Value.ToString()
            );
        }

        private void dgv_employee_load_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedId = int.Parse(dgv_employee_load.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_employee_name.Text = dgv_employee_load.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtp_for_employee.Value = DateTime.Parse(
                dgv_employee_load.Rows[e.RowIndex].Cells[2].Value.ToString()
            );
        }

        private void btn_employee_delete_Click(object sender, EventArgs e)
        {
            if (selectedId != null)
            {
                DialogResult confirm = MessageBox.Show(
                    "Are you sure you want to delete this employee?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm == DialogResult.Yes)
                {
                    Database.Execute(
                        "DELETE FROM NhanVien WHERE MaNhanVien = @manhanvien",
                        new Dictionary<string, object>() { { "@manhanvien", selectedId } }
                    );

                    loadEmployeeScreen();

                    MessageBox.Show(
                        "Employee deleted successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            else
            {
                MessageBox.Show(
                    "No employee selected to delete.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
    }
}
