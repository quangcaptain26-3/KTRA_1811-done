namespace KTRA_1811
{
    partial class TypeOfCert
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cert_name = new System.Windows.Forms.TextBox();
            this.txt_cert_value = new System.Windows.Forms.TextBox();
            this.cbb_cert_id = new System.Windows.Forms.ComboBox();
            this.dgv_cert_load = new System.Windows.Forms.DataGridView();
            this.btn_cert_add = new System.Windows.Forms.Button();
            this.btn_cert_update = new System.Windows.Forms.Button();
            this.btn_cert_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cert_load)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Loại Chứng Chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Ngôn Ngữ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 285);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thời Hạn";
            // 
            // txt_cert_name
            // 
            this.txt_cert_name.Location = new System.Drawing.Point(297, 117);
            this.txt_cert_name.Name = "txt_cert_name";
            this.txt_cert_name.Size = new System.Drawing.Size(265, 27);
            this.txt_cert_name.TabIndex = 3;
            // 
            // txt_cert_value
            // 
            this.txt_cert_value.Location = new System.Drawing.Point(297, 282);
            this.txt_cert_value.Name = "txt_cert_value";
            this.txt_cert_value.Size = new System.Drawing.Size(265, 27);
            this.txt_cert_value.TabIndex = 4;
            // 
            // cbb_cert_id
            // 
            this.cbb_cert_id.DisplayMember = "TenNgonNgu";
            this.cbb_cert_id.FormattingEnabled = true;
            this.cbb_cert_id.Location = new System.Drawing.Point(294, 208);
            this.cbb_cert_id.Name = "cbb_cert_id";
            this.cbb_cert_id.Size = new System.Drawing.Size(267, 28);
            this.cbb_cert_id.TabIndex = 5;
            this.cbb_cert_id.ValueMember = "MaNgonNgu";
            // 
            // dgv_cert_load
            // 
            this.dgv_cert_load.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cert_load.Location = new System.Drawing.Point(725, 75);
            this.dgv_cert_load.Name = "dgv_cert_load";
            this.dgv_cert_load.RowHeadersWidth = 51;
            this.dgv_cert_load.RowTemplate.Height = 24;
            this.dgv_cert_load.Size = new System.Drawing.Size(514, 478);
            this.dgv_cert_load.TabIndex = 6;
            this.dgv_cert_load.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cert_load_CellContentClick);
            this.dgv_cert_load.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cert_load_RowEnter);
            // 
            // btn_cert_add
            // 
            this.btn_cert_add.Location = new System.Drawing.Point(59, 377);
            this.btn_cert_add.Name = "btn_cert_add";
            this.btn_cert_add.Size = new System.Drawing.Size(125, 48);
            this.btn_cert_add.TabIndex = 7;
            this.btn_cert_add.Text = "Thêm";
            this.btn_cert_add.UseVisualStyleBackColor = true;
            this.btn_cert_add.Click += new System.EventHandler(this.btn_cert_add_Click);
            // 
            // btn_cert_update
            // 
            this.btn_cert_update.Location = new System.Drawing.Point(257, 377);
            this.btn_cert_update.Name = "btn_cert_update";
            this.btn_cert_update.Size = new System.Drawing.Size(125, 48);
            this.btn_cert_update.TabIndex = 8;
            this.btn_cert_update.Text = "Sửa";
            this.btn_cert_update.UseVisualStyleBackColor = true;
            this.btn_cert_update.Click += new System.EventHandler(this.btn_cert_update_Click);
            // 
            // btn_cert_delete
            // 
            this.btn_cert_delete.Location = new System.Drawing.Point(455, 377);
            this.btn_cert_delete.Name = "btn_cert_delete";
            this.btn_cert_delete.Size = new System.Drawing.Size(125, 48);
            this.btn_cert_delete.TabIndex = 9;
            this.btn_cert_delete.Text = "Xoá";
            this.btn_cert_delete.UseVisualStyleBackColor = true;
            this.btn_cert_delete.Click += new System.EventHandler(this.btn_cert_delete_Click);
            // 
            // TypeOfCert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 704);
            this.Controls.Add(this.btn_cert_delete);
            this.Controls.Add(this.btn_cert_update);
            this.Controls.Add(this.btn_cert_add);
            this.Controls.Add(this.dgv_cert_load);
            this.Controls.Add(this.cbb_cert_id);
            this.Controls.Add(this.txt_cert_value);
            this.Controls.Add(this.txt_cert_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TypeOfCert";
            this.Text = "TypeOfCert";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cert_load)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cert_name;
        private System.Windows.Forms.TextBox txt_cert_value;
        private System.Windows.Forms.ComboBox cbb_cert_id;
        private System.Windows.Forms.DataGridView dgv_cert_load;
        private System.Windows.Forms.Button btn_cert_add;
        private System.Windows.Forms.Button btn_cert_update;
        private System.Windows.Forms.Button btn_cert_delete;
    }
}