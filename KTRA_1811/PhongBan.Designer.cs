namespace KTRA_1811
{
    partial class PhongBan
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
            this.txt_department_id = new System.Windows.Forms.TextBox();
            this.txt_department_name = new System.Windows.Forms.TextBox();
            this.btn_department_add = new System.Windows.Forms.Button();
            this.btn_department_update = new System.Windows.Forms.Button();
            this.btn_department_delete = new System.Windows.Forms.Button();
            this.dgv_department_load = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_department_load)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Phòng Ban:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Phòng Ban:";
            // 
            // txt_department_id
            // 
            this.txt_department_id.Location = new System.Drawing.Point(200, 23);
            this.txt_department_id.Name = "txt_department_id";
            this.txt_department_id.Size = new System.Drawing.Size(224, 27);
            this.txt_department_id.TabIndex = 2;
            // 
            // txt_department_name
            // 
            this.txt_department_name.Location = new System.Drawing.Point(200, 69);
            this.txt_department_name.Name = "txt_department_name";
            this.txt_department_name.Size = new System.Drawing.Size(224, 27);
            this.txt_department_name.TabIndex = 3;
            // 
            // btn_department_add
            // 
            this.btn_department_add.Location = new System.Drawing.Point(62, 145);
            this.btn_department_add.Name = "btn_department_add";
            this.btn_department_add.Size = new System.Drawing.Size(89, 50);
            this.btn_department_add.TabIndex = 4;
            this.btn_department_add.Text = "Thêm";
            this.btn_department_add.UseVisualStyleBackColor = true;
            this.btn_department_add.Click += new System.EventHandler(this.btn_department_add_Click);
            // 
            // btn_department_update
            // 
            this.btn_department_update.Location = new System.Drawing.Point(200, 145);
            this.btn_department_update.Name = "btn_department_update";
            this.btn_department_update.Size = new System.Drawing.Size(89, 50);
            this.btn_department_update.TabIndex = 5;
            this.btn_department_update.Text = "Sửa";
            this.btn_department_update.UseVisualStyleBackColor = true;
            this.btn_department_update.Click += new System.EventHandler(this.btn_department_update_Click);
            // 
            // btn_department_delete
            // 
            this.btn_department_delete.Location = new System.Drawing.Point(335, 145);
            this.btn_department_delete.Name = "btn_department_delete";
            this.btn_department_delete.Size = new System.Drawing.Size(89, 50);
            this.btn_department_delete.TabIndex = 6;
            this.btn_department_delete.Text = "Xoá";
            this.btn_department_delete.UseVisualStyleBackColor = true;
            this.btn_department_delete.Click += new System.EventHandler(this.btn_department_delete_Click);
            // 
            // dgv_department_load
            // 
            this.dgv_department_load.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_department_load.Location = new System.Drawing.Point(597, 23);
            this.dgv_department_load.Name = "dgv_department_load";
            this.dgv_department_load.RowHeadersWidth = 51;
            this.dgv_department_load.RowTemplate.Height = 24;
            this.dgv_department_load.Size = new System.Drawing.Size(449, 431);
            this.dgv_department_load.TabIndex = 7;
            this.dgv_department_load.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_department_load_CellContentClick);
            this.dgv_department_load.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_department_load_RowEnter);
            // 
            // PhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 613);
            this.Controls.Add(this.dgv_department_load);
            this.Controls.Add(this.btn_department_delete);
            this.Controls.Add(this.btn_department_update);
            this.Controls.Add(this.btn_department_add);
            this.Controls.Add(this.txt_department_name);
            this.Controls.Add(this.txt_department_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PhongBan";
            this.Text = "PhongBan";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_department_load)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_department_id;
        private System.Windows.Forms.TextBox txt_department_name;
        private System.Windows.Forms.Button btn_department_add;
        private System.Windows.Forms.Button btn_department_update;
        private System.Windows.Forms.Button btn_department_delete;
        private System.Windows.Forms.DataGridView dgv_department_load;
    }
}