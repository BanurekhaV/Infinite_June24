using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApI_1.Models;

namespace WebApI_1.Controllers
{
    [RoutePrefix("api/User")]
    public class PersonController : ApiController
    {
        List<Person> personlist = new List<Person>()
        {
            new Person{Id=1,Personname="Yudhister",Designation="President",Gender="Male"},
            new Person{Id=2,Personname="Draupadi",Designation="VicePresident",Gender="Female"},
            new Person{Id=3,Personname="Bheem",Designation="Security",Gender="Male"},
            new Person{Id=4,Personname="Arjun",Designation="Operations",Gender="Male"},
        };

        [HttpGet]
        [Route("All")]
        public IEnumerable<Person>Get()
        {
            return personlist;
        }

        [HttpGet]
        [Route("Bymsg")]
        public HttpResponseMessage GetAllPersons()
        {
            //creating response with both the data as well as the status to the request 
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, personlist);

            //when we need to respond just with a message then we can do so as below
            // response.Content = new StringContent("Received Thanks");
            return response;
        }

        [HttpGet]
        [Route("ById")]
        public IHttpActionResult GetPersonByName(int pId)
        {
            string pname = personlist.Where(p => p.Id == pId).SingleOrDefault()?.Personname;
            if(pname == null)
            {
                return NotFound();
            }
            return Ok(pname);
        }

        //Post 1
        [HttpPost]
        [Route("AllPost")]
        public List<Person>PostAll([FromBody]Person person)
        {
            personlist.Add(person);
            return personlist;
        }

        //Post 2
        [HttpPost]
        [Route("personpost")]
        public IEnumerable<Person> PersonPost([FromUri]int Id, string name, string desig)
        {
            Person person = new Person();
            person.Id = Id;
            person.Personname = name;
            person.Designation = desig;
            personlist.Add(person);
            return personlist;
        }

        [HttpPut]
       // [Route("updperson")]
        public IEnumerable<Person>Put(int pid,[FromUri] Person p)
        {
            personlist[pid - 1] = p;
            return personlist;
        }

        [HttpDelete]
        [Route("delperson")]
        public IEnumerable<Person>Delete(int pid)
        {
            personlist.RemoveAt(pid - 1);
            return personlist;
        }
    }
}
