using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CustomerDataAccessv2;
using CustomerServices;

namespace CustomerServices.Controllers
{
    public class CustomerController : ApiController
    {
        public IEnumerable<customer_data> Get()
        {
            using (CustomersEntities entities = new CustomersEntities())
            {
                return entities.customer_data.ToList();
            }
        }

        public customer_data Get(int id)
        {
            using(CustomersEntities entities = new CustomersEntities())
            {
                return entities.customer_data.FirstOrDefault(e => e.id == id);
            }
        }
    }
}
