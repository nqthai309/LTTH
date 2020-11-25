namespace WebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class hotel_booking
    {
        public int id { get; set; }

        public int? user_id { get; set; }

        [StringLength(100)]
        public string customer_name { get; set; }

        [StringLength(100)]
        public string customer_email { get; set; }

        [StringLength(100)]
        public string customer_phone { get; set; }

        [StringLength(100)]
        public string customer_address { get; set; }

        public int? hotel_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? from_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? to_date { get; set; }

        public int? total_price { get; set; }

        public virtual hotel hotel { get; set; }

        public hotel_booking(int? user_id, string customer_name, string customer_email, string customer_phone, string customer_address, int? hotel_id, DateTime? from_date, DateTime? to_date, int? total_price)
        {
            this.user_id = user_id;
            this.customer_name = customer_name;
            this.customer_email = customer_email;
            this.customer_phone = customer_phone;
            this.customer_address = customer_address;
            this.hotel_id = hotel_id;
            this.from_date = from_date;
            this.to_date = to_date;
            this.total_price = total_price;
        }

        public hotel_booking()
        {
        }
    }
}
