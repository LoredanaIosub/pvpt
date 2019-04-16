using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pvpt.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; } //tastezi prop, apesi tab 2 ori
        [MaxLength(30)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        [MaxLength(300)]
        public string FeedBack{ get; set; }

    }
}