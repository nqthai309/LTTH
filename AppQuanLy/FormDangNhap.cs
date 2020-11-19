using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLy
{
    public partial class FormDangNhap : Form
    {
        static ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string result = client.DangNhapAppWinForm(username, password);
            if(result == "1") 
            {
                MessageBox.Show("thanh cong");
            }
            else
            {
                MessageBox.Show("that bai");
            }
        }
    }
}
