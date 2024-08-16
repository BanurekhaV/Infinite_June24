using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApI_1.Controllers
{
    public class DemoController : ApiController
    {
        List<string> continents = new List<string> { "Asia", "Africa", "America", "Anartica", "Australia", "Europe" };

        //Get : api/Demo
        public IEnumerable<string>Get()
        {
            return continents;
        }

        //Get :api/Demo/Id
        public string Get(int Id)
        {
            return continents[Id - 1];
        }

        //Post : api.Demo
        public IEnumerable<string>Post([FromBody] string data)
        {
            continents.Add(data);
            return continents;
        }

        //Put: api/Demo/Id
        public IEnumerable<string>Put(int Id, [FromUri]string c)
        {
            continents[Id - 1] = c;
            return continents;
        }

        //Delete : api/Demo/Id
        public IEnumerable<string>Delete(int Id)
        {
            continents.RemoveAt(Id - 1);
            return continents;
        }
    }
}
