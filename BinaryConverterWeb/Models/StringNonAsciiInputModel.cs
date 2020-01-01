using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BinaryConverterWeb.Models
{
    public class StringNonAsciiInputModel
    {
        [Required(ErrorMessage = "you must be enter your name or text")]
        [DisplayName("Your Name/Text ")]
        ////[StringLength(1000, MinimumLength = 1, ErrorMessage = "minimum length 1 char and maximum length 1000 char")]

        public string Text { get; set; }
    }
}