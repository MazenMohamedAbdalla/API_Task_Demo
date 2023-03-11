using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiTest.Models;

namespace WebApiTest.Controllers
{
    /// <summary>
    /// All info about Peopel controller.
    /// </summary>
    public class PeopleController : ApiController
    {
        List<people> People = new List<people>();

        public PeopleController()
        {
            People.Add(new people { fName = "Ali", lName = "Gamal", id = 1 });
            People.Add(new people { fName = "Ahmed", lName = "Kamal", id = 2 });
            People.Add(new people { fName = "Gala", lName = "Ali", id = 3 });
            People.Add(new people { fName = "Omar", lName = "Ahmed", id = 4 });
        }

        /// <summary>
        /// Get first names of all users 
        /// </summary>
        /// <returns></returns>

        [Route("api/people/GetFirstNames")]
        [HttpGet]
        public List<string> GetFirstName()
        {
            List<string> result = new List<string>();
            foreach (var p in People)
            {
                result.Add(p.fName);
            }
            return result;
        }

        // GET: api/People
        public List<people> Get()
        {
            return People;
        }

        // GET: api/People/5
        public people Get(int id)
        {
            return People.Where(x => x.id == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post(people value)
        {
            People.Add(value);
        }

        // PUT: api/People/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
            
        }
    }
}
