using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace YCwebTest.Models.ViewModel
{
    public class DetailViewModel
    {
        [DisplayName("會員編號")]
        public int CustomerID { get; set; }

        [DisplayName("姓名")]
        public string CustomerName { get; set; }

        [DisplayName("電子信箱")]
        public string Email { get; set; }
    }
}