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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_phongban_check_Click(object sender, EventArgs e)
        {
            PhongBan phongBan = new PhongBan();
            phongBan.Show();
        }

        private void btn_nhanvien_check_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.Show();
        }

        private void btn_typeofcert_check_Click(object sender, EventArgs e)
        {
            TypeOfCert typeOfCert = new TypeOfCert();
            typeOfCert.Show();
        }

        private void btn_cert_check_Click(object sender, EventArgs e)
        {
            ChungChi chungChi = new ChungChi();
            chungChi.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            // Làm mờ form chính
            this.Opacity = 0.8;

            // Hiển thị hộp thoại xác nhận thoát
            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to exit? All unsaved data will be lost.",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
            );

            // Nếu chọn Yes, thêm hiệu ứng đóng
            if (dialogResult == DialogResult.Yes)
            {
                for (double i = 1.0; i > 0; i -= 0.1)
                {
                    this.Opacity = i; // Hiệu ứng mờ dần
                    System.Threading.Thread.Sleep(50); // Giảm tốc độ mờ
                }
                Application.Exit();
            }
            else
            {
                // Khôi phục form chính nếu chọn No
                this.Opacity = 1.0;
            }
        }
    }
}
