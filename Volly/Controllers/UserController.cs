using System.Collections.Generic;
using System.Web.Http;
using Volly.Models.DataModel;

namespace Volly.Controllers
{
    public class UserController : ApiController
    {
        public static VollyModel vollyModel = new VollyModel();

        // GET api/<controller>
        public IEnumerable<User> Get()
        {
            return vollyModel.Users;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]User user)
        {
            vollyModel.Users.Add(user);
            vollyModel.SaveChanges();
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}