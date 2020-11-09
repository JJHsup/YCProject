using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YCwebTest.Data;
using YCwebTest.Models;

namespace YCwebTest.Repository
{
    public class GetEmRepository
    {
        private readonly YCwebTestContext db = new YCwebTestContext();

        public List<Customer> GetAllCustomer()
        {
            List<Customer> customers;
            customers = db.Customers.ToList();
            return customers;
        }
    }
}