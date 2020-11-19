using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppQuanLy.Models;
using Newtonsoft.Json;


namespace AppQuanLy
{
    public partial class FormUser : Form
    {
        static ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();

        public FormUser()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            var list = JsonConvert.DeserializeObject<List<user>>(client.GetListUser_BE());
            dtUser.DataSource = list;
        }

        private void dtUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectRow = dtUser.Rows[index];
                txtUsername.Text = selectRow.Cells[1].Value.ToString().Trim();
                txtPassword.Text = selectRow.Cells[2].Value.ToString().Trim();
                comboBoxRoleID.SelectedItem = selectRow.Cells[3].Value.ToString().Trim();
                txtFullname.Text = selectRow.Cells[4].Value.ToString().Trim();
                txtEmail.Text = selectRow.Cells[5].Value.ToString().Trim();
                txtPhone.Text = selectRow.Cells[6].Value.ToString().Trim();
                txtAddress.Text = selectRow.Cells[7].Value.ToString().Trim();
               

                //manv = selectRow.Cells[0].Value.ToString().Trim();
            }
            catch
            {

            }
        }
    }
}
