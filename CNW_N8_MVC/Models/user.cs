namespace CNW_N8_MVC.Models
{
    //using CNW_N8_MVC.ServiceReference3;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;
    using System.Xml;
    using System.Xml.Schema;

    
    public partial class user
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string username { get; set; }

        [Required]
        [StringLength(50)]
        public string password { get; set; }

        public int role_id { get; set; }

        [Required]
        [StringLength(50)]
        public string email { get; set; }

        [Required]
        [StringLength(50)]
        public string phone { get; set; }

        [Required]
        [StringLength(50)]
        public string address { get; set; }

        [Required]
        [StringLength(50)]
        public string full_name { get; set; }

        public user(int id, string username, string password, int role_id, string email, string phone, string address, string full_name)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.role_id = role_id;
            this.email = email;
            this.phone = phone;
            this.address = address;
            this.full_name = full_name;
        }

        public user()
        {
        }
    }
}
