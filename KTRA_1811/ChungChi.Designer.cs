namespace KTRA_1811
{
    partial class ChungChi
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_for_cert = new System.Windows.Forms.DateTimePicker();
            this.txt_placeof_cert = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_for_cert_id = new System.Windows.Forms.ComboBox();
            this.cbb_for_employee_id = new System.Windows.Forms.ComboBox();
            this.btn_add_cert = new System.Windows.Forms.Button();
            this.btn_update_cert = new System.Windows.Forms.Button();
            this.btn_delete_cert = new System.Windows.Forms.Button();
            this.dgv_manage_cert = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_manage_cert)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày cấp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nơi cấp:";
            // 
            // dtp_for_cert
            // 
            this.dtp_for_cert.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_for_cert.Location = new System.Drawing.Point(158, 139);
            this.dtp_for_cert.Name = "dtp_for_cert";
            this.dtp_for_cert.Size = new System.Drawing.Size(206, 27);
            this.dtp_for_cert.TabIndex = 2;
            // 
            // txt_placeof_cert
            // 
            this.txt_placeof_cert.Location = new System.Drawing.Point(158, 205);
            this.txt_placeof_cert.Name = "txt_placeof_cert";
            this.txt_placeof_cert.Size = new System.Drawing.Size(206, 27);
            this.txt_placeof_cert.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã loại chứng chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã nhân viên:";
            // 
            // cbb_for_cert_id
            // 
            this.cbb_for_cert_id.DisplayMember = "TenLoaiChungChi";
            this.cbb_for_cert_id.FormattingEnabled = true;
            this.cbb_for_cert_id.Location = new System.Drawing.Point(221, 25);
            this.cbb_for_cert_id.Name = "cbb_for_cert_id";
            this.cbb_for_cert_id.Size = new System.Drawing.Size(143, 28);
            this.cbb_for_cert_id.TabIndex = 6;
            this.cbb_for_cert_id.ValueMember = "MaLoaiChungChi";
            // 
            // cbb_for_employee_id
            // 
            this.cbb_for_employee_id.DisplayMember = "HoTen";
            this.cbb_for_employee_id.FormattingEnabled = true;
            this.cbb_for_employee_id.Location = new System.Drawing.Point(221, 75);
            this.cbb_for_employee_id.Name = "cbb_for_employee_id";
            this.cbb_for_employee_id.Size = new System.Drawing.Size(143, 28);
            this.cbb_for_employee_id.TabIndex = 7;
            this.cbb_for_employee_id.ValueMember = "MaNhanVien";
            // 
            // btn_add_cert
            // 
            this.btn_add_cert.Location = new System.Drawing.Point(31, 281);
            this.btn_add_cert.Name = "btn_add_cert";
            this.btn_add_cert.Size = new System.Drawing.Size(107, 61);
            this.btn_add_cert.TabIndex = 8;
            this.btn_add_cert.Text = "Thêm";
            this.btn_add_cert.UseVisualStyleBackColor = true;
            this.btn_add_cert.Click += new System.EventHandler(this.btn_add_cert_Click);
            // 
            // btn_update_cert
            // 
            this.btn_update_cert.Location = new System.Drawing.Point(144, 281);
            this.btn_update_cert.Name = "btn_update_cert";
            this.btn_update_cert.Size = new System.Drawing.Size(107, 61);
            this.btn_update_cert.TabIndex = 9;
            this.btn_update_cert.Text = "Sửa";
            this.btn_update_cert.UseVisualStyleBackColor = true;
            this.btn_update_cert.Click += new System.EventHandler(this.btn_update_cert_Click);
            // 
            // btn_delete_cert
            // 
            this.btn_delete_cert.Location = new System.Drawing.Point(257, 281);
            this.btn_delete_cert.Name = "btn_delete_cert";
            this.btn_delete_cert.Size = new System.Drawing.Size(107, 61);
            this.btn_delete_cert.TabIndex = 10;
            this.btn_delete_cert.Text = "Xoá";
            this.btn_delete_cert.UseVisualStyleBackColor = true;
            this.btn_delete_cert.Click += new System.EventHandler(this.btn_delete_cert_Click);
            // 
            // dgv_manage_cert
            // 
            this.dgv_manage_cert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_manage_cert.Location = new System.Drawing.Point(476, 25);
            this.dgv_manage_cert.Name = "dgv_manage_cert";
            this.dgv_manage_cert.RowHeadersWidth = 51;
            this.dgv_manage_cert.RowTemplate.Height = 24;
            this.dgv_manage_cert.Size = new System.Drawing.Size(691, 317);
            this.dgv_manage_cert.TabIndex = 11;
            this.dgv_manage_cert.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_manage_cert_CellContentClick);
            this.dgv_manage_cert.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_manage_cert_RowEnter);
            // 
            // ChungChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 693);
            this.Controls.Add(this.dgv_manage_cert);
            this.Controls.Add(this.btn_delete_cert);
            this.Controls.Add(this.btn_update_cert);
            this.Controls.Add(this.btn_add_cert);
            this.Controls.Add(this.cbb_for_employee_id);
            this.Controls.Add(this.cbb_for_cert_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_placeof_cert);
            this.Controls.Add(this.dtp_for_cert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChungChi";
            this.Text = "ChungChi";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_manage_cert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_for_cert;
        private System.Windows.Forms.TextBox txt_placeof_cert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbb_for_cert_id;
        private System.Windows.Forms.ComboBox cbb_for_employee_id;
        private System.Windows.Forms.Button btn_add_cert;
        private System.Windows.Forms.Button btn_update_cert;
        private System.Windows.Forms.Button btn_delete_cert;
        private System.Windows.Forms.DataGridView dgv_manage_cert;
    }
}