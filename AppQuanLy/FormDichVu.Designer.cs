namespace AppQuanLy
{
    partial class FormDichVu
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
            this.components = new System.ComponentModel.Container();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.idHTHSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDichVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDichVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDichVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dichVuHTHSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cNW_N8_TTHT1DataSet = new AppQuanLy.CNW_N8_TTHT1DataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.comboBoxDV = new System.Windows.Forms.ComboBox();
            this.comboBoxTheLoai = new System.Windows.Forms.ComboBox();
            this.comboBoxHTHS = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dichVu_HT_HSTableAdapter = new AppQuanLy.CNW_N8_TTHT1DataSetTableAdapters.DichVu_HT_HSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuHTHSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNW_N8_TTHT1DataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.AllowUserToAddRows = false;
            this.dgvDichVu.AllowUserToDeleteRows = false;
            this.dgvDichVu.AutoGenerateColumns = false;
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idHTHSDataGridViewTextBoxColumn,
            this.theLoaiDataGridViewTextBoxColumn,
            this.idDichVuDataGridViewTextBoxColumn,
            this.tenDichVuDataGridViewTextBoxColumn,
            this.donGiaDichVuDataGridViewTextBoxColumn});
            this.dgvDichVu.DataSource = this.dichVuHTHSBindingSource;
            this.dgvDichVu.Location = new System.Drawing.Point(12, 12);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.ReadOnly = true;
            this.dgvDichVu.Size = new System.Drawing.Size(740, 236);
            this.dgvDichVu.TabIndex = 0;
            this.dgvDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDichVu_CellClick);
            this.dgvDichVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDichVu_CellContentClick);
            // 
            // idHTHSDataGridViewTextBoxColumn
            // 
            this.idHTHSDataGridViewTextBoxColumn.DataPropertyName = "idHTHS";
            this.idHTHSDataGridViewTextBoxColumn.HeaderText = "idHTHS";
            this.idHTHSDataGridViewTextBoxColumn.Name = "idHTHSDataGridViewTextBoxColumn";
            this.idHTHSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // theLoaiDataGridViewTextBoxColumn
            // 
            this.theLoaiDataGridViewTextBoxColumn.DataPropertyName = "theLoai";
            this.theLoaiDataGridViewTextBoxColumn.HeaderText = "theLoai";
            this.theLoaiDataGridViewTextBoxColumn.Name = "theLoaiDataGridViewTextBoxColumn";
            this.theLoaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDichVuDataGridViewTextBoxColumn
            // 
            this.idDichVuDataGridViewTextBoxColumn.DataPropertyName = "idDichVu";
            this.idDichVuDataGridViewTextBoxColumn.HeaderText = "idDichVu";
            this.idDichVuDataGridViewTextBoxColumn.Name = "idDichVuDataGridViewTextBoxColumn";
            this.idDichVuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenDichVuDataGridViewTextBoxColumn
            // 
            this.tenDichVuDataGridViewTextBoxColumn.DataPropertyName = "tenDichVu";
            this.tenDichVuDataGridViewTextBoxColumn.HeaderText = "tenDichVu";
            this.tenDichVuDataGridViewTextBoxColumn.Name = "tenDichVuDataGridViewTextBoxColumn";
            this.tenDichVuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // donGiaDichVuDataGridViewTextBoxColumn
            // 
            this.donGiaDichVuDataGridViewTextBoxColumn.DataPropertyName = "donGiaDichVu";
            this.donGiaDichVuDataGridViewTextBoxColumn.HeaderText = "donGiaDichVu";
            this.donGiaDichVuDataGridViewTextBoxColumn.Name = "donGiaDichVuDataGridViewTextBoxColumn";
            this.donGiaDichVuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dichVuHTHSBindingSource
            // 
            this.dichVuHTHSBindingSource.DataMember = "DichVu_HT_HS";
            this.dichVuHTHSBindingSource.DataSource = this.cNW_N8_TTHT1DataSet;
            // 
            // cNW_N8_TTHT1DataSet
            // 
            this.cNW_N8_TTHT1DataSet.DataSetName = "CNW_N8_TTHT1DataSet";
            this.cNW_N8_TTHT1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnThemMoi);
            this.groupBox1.Controls.Add(this.txtTenDV);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.comboBoxDV);
            this.groupBox1.Controls.Add(this.comboBoxTheLoai);
            this.groupBox1.Controls.Add(this.comboBoxHTHS);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Bell MT", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 204);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết Dịch vụ";
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(412, 146);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(109, 40);
            this.btnDel.TabIndex = 18;
            this.btnDel.Text = "XÓA";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(225, 146);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 40);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "THÊM";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Location = new System.Drawing.Point(352, 67);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(27, 24);
            this.btnThemMoi.TabIndex = 16;
            this.btnThemMoi.Text = "+";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // txtTenDV
            // 
            this.txtTenDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDV.Location = new System.Drawing.Point(175, 106);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(159, 24);
            this.txtTenDV.TabIndex = 15;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(515, 74);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(159, 24);
            this.txtDonGia.TabIndex = 14;
            // 
            // comboBoxDV
            // 
            this.comboBoxDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDV.FormattingEnabled = true;
            this.comboBoxDV.Location = new System.Drawing.Point(175, 67);
            this.comboBoxDV.Name = "comboBoxDV";
            this.comboBoxDV.Size = new System.Drawing.Size(159, 24);
            this.comboBoxDV.TabIndex = 13;
            this.comboBoxDV.SelectedIndexChanged += new System.EventHandler(this.comboBoxDV_SelectedIndexChanged);
            // 
            // comboBoxTheLoai
            // 
            this.comboBoxTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTheLoai.FormattingEnabled = true;
            this.comboBoxTheLoai.Location = new System.Drawing.Point(515, 32);
            this.comboBoxTheLoai.Name = "comboBoxTheLoai";
            this.comboBoxTheLoai.Size = new System.Drawing.Size(159, 24);
            this.comboBoxTheLoai.TabIndex = 12;
            // 
            // comboBoxHTHS
            // 
            this.comboBoxHTHS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHTHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxHTHS.FormattingEnabled = true;
            this.comboBoxHTHS.Location = new System.Drawing.Point(175, 27);
            this.comboBoxHTHS.Name = "comboBoxHTHS";
            this.comboBoxHTHS.Size = new System.Drawing.Size(159, 24);
            this.comboBoxHTHS.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(409, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Đơn giá :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tên Dịch vụ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(408, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Thể loại :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã Dịch vụ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã Hotel - Homestay :";
            // 
            // dichVu_HT_HSTableAdapter
            // 
            this.dichVu_HT_HSTableAdapter.ClearBeforeFill = true;
            // 
            // FormDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 470);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDichVu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDichVu";
            this.Text = "g";
            this.Load += new System.EventHandler(this.FormDichVu_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuHTHSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNW_N8_TTHT1DataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTheLoai;
        private System.Windows.Forms.ComboBox comboBoxHTHS;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.ComboBox comboBoxDV;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnThemMoi;
        private CNW_N8_TTHT1DataSet cNW_N8_TTHT1DataSet;
        private System.Windows.Forms.BindingSource dichVuHTHSBindingSource;
        private CNW_N8_TTHT1DataSetTableAdapters.DichVu_HT_HSTableAdapter dichVu_HT_HSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHTHSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn theLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDichVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDichVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDichVuDataGridViewTextBoxColumn;
    }
}