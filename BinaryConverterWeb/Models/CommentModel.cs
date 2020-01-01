using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BinaryConverterWeb.Models
{
    public class CommentModel
    {
        public int ID { get; set; }
        [Required]
        [DisplayName("Username ")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Comment ")]
        public string Comment1 { get; set; }
    }
}