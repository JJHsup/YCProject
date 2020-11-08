using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using YCwebTest.Models;

namespace YCwebTest.Data
{
    public class YCwebTestContext : DbContext
    {
        public YCwebTestContext() : base("name=YCwebTestContext")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
    }
}