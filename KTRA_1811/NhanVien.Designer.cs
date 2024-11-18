namespace KTRA_1811
{
    partial class NhanVien
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
            this.txt_employee_name = new System.Windows.Forms.TextBox();
            this.dtp_for_employee = new System.Windows.Forms.DateTimePicker();
            this.btn_employee_add = new System.Windows.Forms.Button();
            this.btn_employee_update = new System.Windows.Forms.Button();
            this.btn_employee_delete = new System.Windows.Forms.Button();
            this.dgv_employee_load = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbDepartment = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employee_load)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày sinh";
            // 
            // txt_employee_name
            // 
            this.txt_employee_name.Location = new System.Drawing.Point(172, 45);
            this.txt_employee_name.Name = "txt_employee_name";
            this.txt_employee_name.Size = new System.Drawing.Size(209, 27);
            this.txt_employee_name.TabIndex = 2;
            // 
            // dtp_for_employee
            // 
            this.dtp_for_employee.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_for_employee.Location = new System.Drawing.Point(172, 88);
            this.dtp_for_employee.Name = "dtp_for_employee";
            this.dtp_for_employee.Size = new System.Drawing.Size(209, 27);
            this.dtp_for_employee.TabIndex = 3;
            // 
            // btn_employee_add
            // 
            this.btn_employee_add.Location = new System.Drawing.Point(50, 203);
            this.btn_employee_add.Name = "btn_employee_add";
            this.btn_employee_add.Size = new System.Drawing.Size(101, 47);
            this.btn_employee_add.TabIndex = 4;
            this.btn_employee_add.Text = "Thêm ";
            this.btn_employee_add.UseVisualStyleBackColor = true;
            this.btn_employee_add.Click += new System.EventHandler(this.btn_employee_add_Click);
            // 
            // btn_employee_update
            // 
            this.btn_employee_update.Location = new System.Drawing.Point(200, 203);
            this.btn_employee_update.Name = "btn_employee_update";
            this.btn_employee_update.Size = new System.Drawing.Size(101, 47);
            this.btn_employee_update.TabIndex = 5;
            this.btn_employee_update.Text = "Sửa";
            this.btn_employee_update.UseVisualStyleBackColor = true;
            this.btn_employee_update.Click += new System.EventHandler(this.btn_employee_update_Click);
            // 
            // btn_employee_delete
            // 
            this.btn_employee_delete.Location = new System.Drawing.Point(347, 203);
            this.btn_employee_delete.Name = "btn_employee_delete";
            this.btn_employee_delete.Size = new System.Drawing.Size(101, 47);
            this.btn_employee_delete.TabIndex = 6;
            this.btn_employee_delete.Text = "Xoá";
            this.btn_employee_delete.UseVisualStyleBackColor = true;
            this.btn_employee_delete.Click += new System.EventHandler(this.btn_employee_delete_Click);
            // 
            // dgv_employee_load
            // 
            this.dgv_employee_load.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_employee_load.Location = new System.Drawing.Point(483, 35);
            this.dgv_employee_load.Name = "dgv_employee_load";
            this.dgv_employee_load.RowHeadersWidth = 51;
            this.dgv_employee_load.RowTemplate.Height = 24;
            this.dgv_employee_load.Size = new System.Drawing.Size(534, 343);
            this.dgv_employee_load.TabIndex = 7;
            this.dgv_employee_load.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_employee_load_CellContentClick);
            this.dgv_employee_load.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_employee_load_RowEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mã phòng ban";
            // 
            // cbbDepartment
            // 
            this.cbbDepartment.DisplayMember = "TenPhongBan";
            this.cbbDepartment.FormattingEnabled = true;
            this.cbbDepartment.Location = new System.Drawing.Point(172, 146);
            this.cbbDepartment.Name = "cbbDepartment";
            this.cbbDepartment.Size = new System.Drawing.Size(137, 28);
            this.cbbDepartment.TabIndex = 9;
            this.cbbDepartment.ValueMember = "MaPhongBan";
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 695);
            this.Controls.Add(this.cbbDepartment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_employee_load);
            this.Controls.Add(this.btn_employee_delete);
            this.Controls.Add(this.btn_employee_update);
            this.Controls.Add(this.btn_employee_add);
            this.Controls.Add(this.dtp_for_employee);
            this.Controls.Add(this.txt_employee_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employee_load)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_employee_name;
        private System.Windows.Forms.DateTimePicker dtp_for_employee;
        private System.Windows.Forms.Button btn_employee_add;
        private System.Windows.Forms.Button btn_employee_update;
        private System.Windows.Forms.Button btn_employee_delete;
        private System.Windows.Forms.DataGridView dgv_employee_load;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbDepartment;
    }
}