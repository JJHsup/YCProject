using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace YCwebTest.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Name")]
        public string CustomerName { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public bool Cofirmpasswordforreset { get; set; }
    }
}