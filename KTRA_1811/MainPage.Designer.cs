namespace KTRA_1811
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_typeofcert_check = new System.Windows.Forms.Button();
            this.btn_phongban_check = new System.Windows.Forms.Button();
            this.btn_nhanvien_check = new System.Windows.Forms.Button();
            this.btn_cert_check = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(602, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Trung Tâm Phát Chứng Chỉ";
            // 
            // btn_typeofcert_check
            // 
            this.btn_typeofcert_check.Location = new System.Drawing.Point(570, 277);
            this.btn_typeofcert_check.Name = "btn_typeofcert_check";
            this.btn_typeofcert_check.Size = new System.Drawing.Size(201, 84);
            this.btn_typeofcert_check.TabIndex = 1;
            this.btn_typeofcert_check.Text = "Xem loại chứng chỉ";
            this.btn_typeofcert_check.UseVisualStyleBackColor = true;
            this.btn_typeofcert_check.Click += new System.EventHandler(this.btn_typeofcert_check_Click);
            // 
            // btn_phongban_check
            // 
            this.btn_phongban_check.Location = new System.Drawing.Point(43, 277);
            this.btn_phongban_check.Name = "btn_phongban_check";
            this.btn_phongban_check.Size = new System.Drawing.Size(201, 84);
            this.btn_phongban_check.TabIndex = 2;
            this.btn_phongban_check.Text = "Xem các phòng ban";
            this.btn_phongban_check.UseVisualStyleBackColor = true;
            this.btn_phongban_check.Click += new System.EventHandler(this.btn_phongban_check_Click);
            // 
            // btn_nhanvien_check
            // 
            this.btn_nhanvien_check.Location = new System.Drawing.Point(303, 277);
            this.btn_nhanvien_check.Name = "btn_nhanvien_check";
            this.btn_nhanvien_check.Size = new System.Drawing.Size(201, 84);
            this.btn_nhanvien_check.TabIndex = 3;
            this.btn_nhanvien_check.Text = "Xem nhân viên";
            this.btn_nhanvien_check.UseVisualStyleBackColor = true;
            this.btn_nhanvien_check.Click += new System.EventHandler(this.btn_nhanvien_check_Click);
            // 
            // btn_cert_check
            // 
            this.btn_cert_check.Location = new System.Drawing.Point(854, 277);
            this.btn_cert_check.Name = "btn_cert_check";
            this.btn_cert_check.Size = new System.Drawing.Size(201, 84);
            this.btn_cert_check.TabIndex = 4;
            this.btn_cert_check.Text = "Xem chứng chỉ";
            this.btn_cert_check.UseVisualStyleBackColor = true;
            this.btn_cert_check.Click += new System.EventHandler(this.btn_cert_check_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(441, 488);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(201, 84);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 670);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_cert_check);
            this.Controls.Add(this.btn_nhanvien_check);
            this.Controls.Add(this.btn_phongban_check);
            this.Controls.Add(this.btn_typeofcert_check);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_typeofcert_check;
        private System.Windows.Forms.Button btn_phongban_check;
        private System.Windows.Forms.Button btn_nhanvien_check;
        private System.Windows.Forms.Button btn_cert_check;
        private System.Windows.Forms.Button btn_exit;
    }
}