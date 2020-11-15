using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebApplication3.Models;

namespace WebApplication3
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        Model1 context = new Model1();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string GetListUser_BE()
        {
            var model = context.users.Where(x => x.id != 0).ToList();
            string json = JsonConvert.SerializeObject(model);
            return json;
        }

        [WebMethod]
        public void EditUser_BE(int id_old, string json)
        {
            user acc = JsonConvert.DeserializeObject<user>(json);
            var result = context.users.Find(id_old);
            context.users.Remove(result);
            context.users.Add(acc);
            context.SaveChanges();
        }

        [WebMethod]
        public void AddUser_BE(string json)
        {
            user acc = JsonConvert.DeserializeObject<user>(json);
            context.users.Add(acc);
            context.SaveChanges();
        }

        [WebMethod]
        public void DeleteUser_BE(int id)
        {
            var result = context.users.Find(id);
            context.users.Remove(result);
            context.SaveChanges();
        }

        [WebMethod]
        public string GetListHotel_BE()
        {
            var list = context.hotels.Where(x => x.id != 0).ToList();
            string json = JsonConvert.SerializeObject(list, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return json;
        }

        [WebMethod]
        public void AddHotel_BE(string json)
        {
            var hotel = JsonConvert.DeserializeObject<hotel>(json);
            context.hotels.Add(hotel);
            context.SaveChanges();
        }

        [WebMethod]
        public void EditHotel_BE(int id_old, string json)
        {
            context.hotels.Remove(context.hotels.Find(id_old));
            context.hotels.Add(JsonConvert.DeserializeObject<hotel>(json));
            context.SaveChanges();
        }

        [WebMethod]
        public void DeleteHotel_BE(int id)
        {
            context.hotels.Remove(context.hotels.Find(id));
            context.SaveChanges();
        }

        [WebMethod]
        public string GetListHomestay_BE()
        {
            var list = context.homestays.Where(x => x.id != 0).ToList();
            string json = JsonConvert.SerializeObject(list, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return json;
        }

        [WebMethod]
        public void AddHomestay_BE(string json)
        {
            var homeStay = JsonConvert.DeserializeObject<homestay>(json);
            context.homestays.Add(homeStay);
            context.SaveChanges();
        }

        [WebMethod]
        public void EditHomestay_BE(int id_old, string json)
        {
            context.homestays.Remove(context.homestays.Find(id_old));
            context.homestays.Add(JsonConvert.DeserializeObject<homestay>(json));
            context.SaveChanges();
        }

        [WebMethod]
        public void DeleteHomestay_BE(int id)
        {
            context.homestays.Remove(context.homestays.Find(id));
            context.SaveChanges();
        }

        [WebMethod]
        public string GetListBooking_BE(string key)
        {
            try
            {
                if(key == "hotel_bookings")
                {
                    var json = JsonConvert.SerializeObject(context.hotel_booking.Where(x => x.id != 0).ToList(), Formatting.Indented, new JsonSerializerSettings {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    });
                    return json;
                }
                if(key == "homestay_bookings")
                {
                    var json = JsonConvert.SerializeObject(context.homestay_booking.Where(x => x.id != 0).ToList(), Formatting.Indented, new JsonSerializerSettings {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    });
                    return json;
                }
            }
            catch(Exception e)
            {
                throw e;
            }
            return "";
        }
    }
}
