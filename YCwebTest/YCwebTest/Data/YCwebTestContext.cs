using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace YCwebTest.Data
{
    public class YCwebTestContext : DbContext
    {
        public YCwebTestContext() : base("name=YCwebTestContext")
        {
        }

        public System.Data.Entity.DbSet<YCwebTest.Models.Customer> Customers { get; set; }
    }
}