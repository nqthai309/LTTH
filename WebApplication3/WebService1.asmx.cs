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
        //------------------------THAI----------------------------------
        [WebMethod]
        public string DangNhapAppWinForm(string username, string password)
        {
            var list = context.users.Where(x => x.id != 0).ToList();
            foreach (var item in list)
            {
                if (username == item.username && password == item.password)
                {
                    return "1";
                }
            }
            return "0";
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
            var row_bookings = context.hotel_booking.Where(x => x.hotel_id == id_old).ToList();
            var newRows = row_bookings;
            foreach (var item in row_bookings)
            {
                context.hotel_booking.Remove(item);
            }
            context.hotels.Remove(context.hotels.Find(id_old));
            var hotel = JsonConvert.DeserializeObject<hotel>(json);
            context.hotels.Add(hotel);
            context.SaveChanges();
            foreach (var item in newRows)
            {
                item.hotel_id = hotel.id;
                context.hotel_booking.Add(item);
            }
            context.SaveChanges();
        }

        [WebMethod]
        public void DeleteHotel_BE(int id)
        {
            var listBooking = context.hotel_booking.Where(x => x.hotel_id == id).ToList();
            foreach (var item in listBooking)
            {
                context.hotel_booking.Remove(item);
            }
            context.SaveChanges();
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
            var row_bookings = context.homestay_booking.Where(x => x.homestay_id == id_old).ToList();
            var newRows = row_bookings;
            foreach (var item in row_bookings)
            {
                context.homestay_booking.Remove(item);
            }
            context.homestays.Remove(context.homestays.Find(id_old));
            var homeStay = JsonConvert.DeserializeObject<homestay>(json);
            context.homestays.Add(homeStay);
            context.SaveChanges();
            foreach (var item in newRows)
            {
                item.homestay_id = homeStay.id;
                context.homestay_booking.Add(item);
            }
            context.SaveChanges();
        }

        [WebMethod]
        public void DeleteHomestay_BE(int id)
        {
            var listBooking = context.homestay_booking.Where(x => x.homestay_id == id).ToList();
            foreach (var item in listBooking)
            {
                context.homestay_booking.Remove(item);
            }
            context.SaveChanges();
            context.homestays.Remove(context.homestays.Find(id));
            context.SaveChanges();
        }

        [WebMethod]
        public string GetListBooking_BE(string key)
        {
            try
            {
                if (key == "hotel_bookings")
                {
                    var json = JsonConvert.SerializeObject(context.hotel_booking.Where(x => x.id != 0).ToList(), Formatting.Indented, new JsonSerializerSettings
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    });
                    return json;
                }
                if (key == "homestay_bookings")
                {
                    var json = JsonConvert.SerializeObject(context.homestay_booking.Where(x => x.id != 0).ToList(), Formatting.Indented, new JsonSerializerSettings
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    });
                    return json;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return "";
        }
        //------------------------THAI----------------------------------
        //------------------------TUNG----------------------------------
        //user/home
        [WebMethod]
        public string FrontEndGetListHomestay()
        {
            var list = context.homestays.Where(x => x.id != 0).ToList();
            string json = JsonConvert.SerializeObject(list, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return json;
        }

        [WebMethod]
        public string FrontEndGetListHotel()
        {
            var list = context.hotels.Where(x => x.id != 0).ToList();
            string json = JsonConvert.SerializeObject(list, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return json;
        }


        [WebMethod]
        public string FrontEndFindHomestayById(int id)
        {
            var homestay = context.homestays.Where(x => x.id == id).FirstOrDefault();
            string json = JsonConvert.SerializeObject(homestay, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return json;
        }

        [WebMethod]
        public string FrontEndFindHotelById(int id)
        {
            var hotel = context.hotels.Where(x => x.id == id).FirstOrDefault();
            string json = JsonConvert.SerializeObject(hotel, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return json;
        }

        [WebMethod]
        public string FrontEndGetListLocation()
        {
            var list = context.locations.Where(x => x.id != 0).ToList();
            string json = JsonConvert.SerializeObject(list, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return json;
        }

        [WebMethod]
        public string FrontEndLogin(string username, string password)
        {
            var result = context.users.Where(a => (a.username == username && a.password == password)).FirstOrDefault();
            string json = JsonConvert.SerializeObject(result, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return json;
        }

        [WebMethod]
        public string FrontEndFindUserById(int id)
        {
            var result = context.users.Where(a => (a.id == id)).FirstOrDefault();
            string json = JsonConvert.SerializeObject(result, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return json;
        }

        [WebMethod]
        public string FrontEndFindUserByUsername(string username)
        {
            var result = context.users.Where(a => (a.username == username)).FirstOrDefault();
            string json = JsonConvert.SerializeObject(result, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return json;
        }


        [WebMethod]
        public void FrontEndRegister(string json)
        {
            var user = JsonConvert.DeserializeObject<user>(json);
            context.users.Add(user);
            context.SaveChanges();
        }

        [WebMethod]
        public void FrontEndUpdateUserInfo(int id, string json)
        {
            user acc = JsonConvert.DeserializeObject<user>(json);
            var result = context.users.Find(id);
            context.users.Remove(result);
            context.users.Add(acc);
            context.SaveChanges();
        }

        [WebMethod]
        public void FrontEndChangePassword(int id, string password)
        {
            var result = context.users.Find(id);
            if (result != null)
            {
                result.password = password;
                context.SaveChanges();
            }
        }

        [WebMethod]
        public void FrontEndAddHotelBooking(string json)
        {
            var hotelBooking = JsonConvert.DeserializeObject<hotel_booking>(json);
            context.hotel_booking.Add(hotelBooking);
            context.SaveChanges();
        }

        [WebMethod]
        public void FrontEndAddHomestayBooking(string json)
        {
            var homestayBooking = JsonConvert.DeserializeObject<homestay_booking>(json);
            context.homestay_booking.Add(homestayBooking);
            context.SaveChanges();
        }
        //------------------------TUNG----------------------------------
        //------------------------THANG----------------------------------
        //hotel
        //------------------------THANG----------------------------------
        //------------------------HIEU----------------------------------
        //homestay
        //------------------------HIEU----------------------------------
    }
}
