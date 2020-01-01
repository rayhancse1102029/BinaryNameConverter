using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BinaryConverterWeb.Models
{
    public class RegistrationModel
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Emai { get; set; }
        public string Password { get; set; }
    }
}