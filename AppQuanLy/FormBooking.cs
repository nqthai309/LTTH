using AppQuanLy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace AppQuanLy
{
    public partial class FormBooking : Form
    {
        static ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();
        public FormBooking()
        {
            InitializeComponent();
        }

        private void FormBooking_Load(object sender, EventArgs e)
        {
            List<hotel_booking> hotel_bookings = JsonConvert.DeserializeObject<List<hotel_booking>>(client.GetListBooking_BE("hotel_bookings"));
            List<homestay_booking> homestay_bookings = JsonConvert.DeserializeObject<List<homestay_booking>>(client.GetListBooking_BE("homestay_bookings"));
            dtHotelBooking.DataSource = hotel_bookings;
            dtHomestayBooking.DataSource = homestay_bookings;
        }
    }
}
