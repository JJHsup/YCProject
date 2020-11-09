using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using YCwebTest.Data;
using YCwebTest.Models;

namespace YCwebTest.Controllers
{
    [RoutePrefix("api/[Controller]/[action]")]
    public class CustomerAPIController : ApiController
    {
        private readonly YCwebTestContext db = new YCwebTestContext();

        // GET: api/CRUDapi
        public List<Customer> Get()
        {
            var customer = db.Customers.ToList();
            return customer;
        }
    }
}