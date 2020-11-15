using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Dynamic;

using CNW_N8_MVC.Models;
using Newtonsoft.Json;

namespace CNW_N8_MVC.Areas.Backend.Controllers
{
    public class BackendBookingController : BaseController
    {
        // GET: BackendBooking
        private Model1 context = new Model1();
        static ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();
        public ActionResult List()
        {
            dynamic model = new ExpandoObject();
            
            model.hotel_bookings = JsonConvert.DeserializeObject<List<hotel_booking>>(client.GetListBooking_BE("hotel_bookings"));
            model.homestay_bookings = JsonConvert.DeserializeObject<List<homestay_booking>>(client.GetListBooking_BE("homestay_bookings"));
            return View(model);
        }
    }
}