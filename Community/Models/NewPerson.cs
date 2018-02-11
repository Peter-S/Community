using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Community.Models
{
    public class NewPerson

    {
        public string lastname { get; set; }
        public string firstname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string apartmentNumber { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipcode { get; set; }
        public string phone { get; set; }
    }

}