namespace AppQuanLy
{
    partial class FormBooking
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hotelbookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.homestaybookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.homestayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtHotelBooking = new System.Windows.Forms.DataGridView();
            this.dtHomestayBooking = new System.Windows.Forms.DataGridView();
            this.hotelbookingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeremailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeraddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.todateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homestaybookingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customernameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeremailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerphoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeraddressDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homestayidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromdateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.todateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homestayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.hotelbookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homestaybookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homestayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHotelBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHomestayBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelbookingBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homestaybookingBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Danh Sách Hotel_Booking";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Danh Sách Homestay_Booking";
            // 
            // hotelbookingBindingSource
            // 
            this.hotelbookingBindingSource.DataSource = typeof(AppQuanLy.Models.hotel_booking);
            // 
            // homestaybookingBindingSource
            // 
            this.homestaybookingBindingSource.DataSource = typeof(AppQuanLy.Models.homestay_booking);
            // 
            // hotelBindingSource
            // 
            this.hotelBindingSource.DataSource = typeof(AppQuanLy.Models.hotel);
            // 
            // homestayBindingSource
            // 
            this.homestayBindingSource.DataSource = typeof(AppQuanLy.Models.homestay);
            // 
            // dtHotelBooking
            // 
            this.dtHotelBooking.AutoGenerateColumns = false;
            this.dtHotelBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtHotelBooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn,
            this.customernameDataGridViewTextBoxColumn,
            this.customeremailDataGridViewTextBoxColumn,
            this.customerphoneDataGridViewTextBoxColumn,
            this.customeraddressDataGridViewTextBoxColumn,
            this.hotelidDataGridViewTextBoxColumn,
            this.fromdateDataGridViewTextBoxColumn,
            this.todateDataGridViewTextBoxColumn,
            this.totalpriceDataGridViewTextBoxColumn,
            this.hotelDataGridViewTextBoxColumn});
            this.dtHotelBooking.DataSource = this.hotelbookingBindingSource1;
            this.dtHotelBooking.Location = new System.Drawing.Point(7, 28);
            this.dtHotelBooking.Name = "dtHotelBooking";
            this.dtHotelBooking.Size = new System.Drawing.Size(745, 203);
            this.dtHotelBooking.TabIndex = 5;
            // 
            // dtHomestayBooking
            // 
            this.dtHomestayBooking.AutoGenerateColumns = false;
            this.dtHomestayBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtHomestayBooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.useridDataGridViewTextBoxColumn1,
            this.customernameDataGridViewTextBoxColumn1,
            this.customeremailDataGridViewTextBoxColumn1,
            this.customerphoneDataGridViewTextBoxColumn1,
            this.customeraddressDataGridViewTextBoxColumn1,
            this.homestayidDataGridViewTextBoxColumn,
            this.fromdateDataGridViewTextBoxColumn1,
            this.todateDataGridViewTextBoxColumn1,
            this.totalpriceDataGridViewTextBoxColumn1,
            this.homestayDataGridViewTextBoxColumn});
            this.dtHomestayBooking.DataSource = this.homestaybookingBindingSource1;
            this.dtHomestayBooking.Location = new System.Drawing.Point(7, 257);
            this.dtHomestayBooking.Name = "dtHomestayBooking";
            this.dtHomestayBooking.Size = new System.Drawing.Size(745, 203);
            this.dtHomestayBooking.TabIndex = 5;
            // 
            // hotelbookingBindingSource1
            // 
            this.hotelbookingBindingSource1.DataSource = typeof(AppQuanLy.Models.hotel_booking);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "user_id";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            // 
            // customernameDataGridViewTextBoxColumn
            // 
            this.customernameDataGridViewTextBoxColumn.DataPropertyName = "customer_name";
            this.customernameDataGridViewTextBoxColumn.HeaderText = "customer_name";
            this.customernameDataGridViewTextBoxColumn.Name = "customernameDataGridViewTextBoxColumn";
            // 
            // customeremailDataGridViewTextBoxColumn
            // 
            this.customeremailDataGridViewTextBoxColumn.DataPropertyName = "customer_email";
            this.customeremailDataGridViewTextBoxColumn.HeaderText = "customer_email";
            this.customeremailDataGridViewTextBoxColumn.Name = "customeremailDataGridViewTextBoxColumn";
            // 
            // customerphoneDataGridViewTextBoxColumn
            // 
            this.customerphoneDataGridViewTextBoxColumn.DataPropertyName = "customer_phone";
            this.customerphoneDataGridViewTextBoxColumn.HeaderText = "customer_phone";
            this.customerphoneDataGridViewTextBoxColumn.Name = "customerphoneDataGridViewTextBoxColumn";
            // 
            // customeraddressDataGridViewTextBoxColumn
            // 
            this.customeraddressDataGridViewTextBoxColumn.DataPropertyName = "customer_address";
            this.customeraddressDataGridViewTextBoxColumn.HeaderText = "customer_address";
            this.customeraddressDataGridViewTextBoxColumn.Name = "customeraddressDataGridViewTextBoxColumn";
            // 
            // hotelidDataGridViewTextBoxColumn
            // 
            this.hotelidDataGridViewTextBoxColumn.DataPropertyName = "hotel_id";
            this.hotelidDataGridViewTextBoxColumn.HeaderText = "hotel_id";
            this.hotelidDataGridViewTextBoxColumn.Name = "hotelidDataGridViewTextBoxColumn";
            // 
            // fromdateDataGridViewTextBoxColumn
            // 
            this.fromdateDataGridViewTextBoxColumn.DataPropertyName = "from_date";
            this.fromdateDataGridViewTextBoxColumn.HeaderText = "from_date";
            this.fromdateDataGridViewTextBoxColumn.Name = "fromdateDataGridViewTextBoxColumn";
            // 
            // todateDataGridViewTextBoxColumn
            // 
            this.todateDataGridViewTextBoxColumn.DataPropertyName = "to_date";
            this.todateDataGridViewTextBoxColumn.HeaderText = "to_date";
            this.todateDataGridViewTextBoxColumn.Name = "todateDataGridViewTextBoxColumn";
            // 
            // totalpriceDataGridViewTextBoxColumn
            // 
            this.totalpriceDataGridViewTextBoxColumn.DataPropertyName = "total_price";
            this.totalpriceDataGridViewTextBoxColumn.HeaderText = "total_price";
            this.totalpriceDataGridViewTextBoxColumn.Name = "totalpriceDataGridViewTextBoxColumn";
            // 
            // hotelDataGridViewTextBoxColumn
            // 
            this.hotelDataGridViewTextBoxColumn.DataPropertyName = "hotel";
            this.hotelDataGridViewTextBoxColumn.HeaderText = "hotel";
            this.hotelDataGridViewTextBoxColumn.Name = "hotelDataGridViewTextBoxColumn";
            // 
            // homestaybookingBindingSource1
            // 
            this.homestaybookingBindingSource1.DataSource = typeof(AppQuanLy.Models.homestay_booking);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // useridDataGridViewTextBoxColumn1
            // 
            this.useridDataGridViewTextBoxColumn1.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn1.HeaderText = "user_id";
            this.useridDataGridViewTextBoxColumn1.Name = "useridDataGridViewTextBoxColumn1";
            // 
            // customernameDataGridViewTextBoxColumn1
            // 
            this.customernameDataGridViewTextBoxColumn1.DataPropertyName = "customer_name";
            this.customernameDataGridViewTextBoxColumn1.HeaderText = "customer_name";
            this.customernameDataGridViewTextBoxColumn1.Name = "customernameDataGridViewTextBoxColumn1";
            // 
            // customeremailDataGridViewTextBoxColumn1
            // 
            this.customeremailDataGridViewTextBoxColumn1.DataPropertyName = "customer_email";
            this.customeremailDataGridViewTextBoxColumn1.HeaderText = "customer_email";
            this.customeremailDataGridViewTextBoxColumn1.Name = "customeremailDataGridViewTextBoxColumn1";
            // 
            // customerphoneDataGridViewTextBoxColumn1
            // 
            this.customerphoneDataGridViewTextBoxColumn1.DataPropertyName = "customer_phone";
            this.customerphoneDataGridViewTextBoxColumn1.HeaderText = "customer_phone";
            this.customerphoneDataGridViewTextBoxColumn1.Name = "customerphoneDataGridViewTextBoxColumn1";
            // 
            // customeraddressDataGridViewTextBoxColumn1
            // 
            this.customeraddressDataGridViewTextBoxColumn1.DataPropertyName = "customer_address";
            this.customeraddressDataGridViewTextBoxColumn1.HeaderText = "customer_address";
            this.customeraddressDataGridViewTextBoxColumn1.Name = "customeraddressDataGridViewTextBoxColumn1";
            // 
            // homestayidDataGridViewTextBoxColumn
            // 
            this.homestayidDataGridViewTextBoxColumn.DataPropertyName = "homestay_id";
            this.homestayidDataGridViewTextBoxColumn.HeaderText = "homestay_id";
            this.homestayidDataGridViewTextBoxColumn.Name = "homestayidDataGridViewTextBoxColumn";
            // 
            // fromdateDataGridViewTextBoxColumn1
            // 
            this.fromdateDataGridViewTextBoxColumn1.DataPropertyName = "from_date";
            this.fromdateDataGridViewTextBoxColumn1.HeaderText = "from_date";
            this.fromdateDataGridViewTextBoxColumn1.Name = "fromdateDataGridViewTextBoxColumn1";
            // 
            // todateDataGridViewTextBoxColumn1
            // 
            this.todateDataGridViewTextBoxColumn1.DataPropertyName = "to_date";
            this.todateDataGridViewTextBoxColumn1.HeaderText = "to_date";
            this.todateDataGridViewTextBoxColumn1.Name = "todateDataGridViewTextBoxColumn1";
            // 
            // totalpriceDataGridViewTextBoxColumn1
            // 
            this.totalpriceDataGridViewTextBoxColumn1.DataPropertyName = "total_price";
            this.totalpriceDataGridViewTextBoxColumn1.HeaderText = "total_price";
            this.totalpriceDataGridViewTextBoxColumn1.Name = "totalpriceDataGridViewTextBoxColumn1";
            // 
            // homestayDataGridViewTextBoxColumn
            // 
            this.homestayDataGridViewTextBoxColumn.DataPropertyName = "homestay";
            this.homestayDataGridViewTextBoxColumn.HeaderText = "homestay";
            this.homestayDataGridViewTextBoxColumn.Name = "homestayDataGridViewTextBoxColumn";
            // 
            // FormBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 470);
            this.Controls.Add(this.dtHomestayBooking);
            this.Controls.Add(this.dtHotelBooking);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormBooking";
            this.Text = "FormBooking";
            this.Load += new System.EventHandler(this.FormBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelbookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homestaybookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homestayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHotelBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHomestayBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelbookingBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homestaybookingBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource homestayBindingSource;
        private System.Windows.Forms.BindingSource hotelBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource homestaybookingBindingSource;
        private System.Windows.Forms.BindingSource hotelbookingBindingSource;
        private System.Windows.Forms.DataGridView dtHotelBooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeremailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeraddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn todateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource hotelbookingBindingSource1;
        private System.Windows.Forms.DataGridView dtHomestayBooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customernameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeremailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerphoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeraddressDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn homestayidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromdateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn todateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn homestayDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource homestaybookingBindingSource1;
    }
}