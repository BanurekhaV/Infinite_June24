using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApI_1.Controllers
{
    public class ValuesController : ApiController
    {
        static List<string> str = new List<string>()
        {
            "value1", "value2" , "value3", "value4"
        };
        // GET api/values
        public IEnumerable<string> Get()
        {
            return str;
        }

        // GET api/values/5
        public string Get(int id)
        {
            //return "value";
            return str[id - 1];
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
            str.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromUri] string value)
        {
            str[id - 1] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            str.RemoveAt(id - 1);
        }
    }
}
