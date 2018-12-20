using EmploeeyDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIDemo.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpGet]
        public List<Employees> Get()
        {
            using (EmployeeDBEntities db = new EmployeeDBEntities())
            {
                return db.Employees.ToList();
            }
            
        }
    }
}
