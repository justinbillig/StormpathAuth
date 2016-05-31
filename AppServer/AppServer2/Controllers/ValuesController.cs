using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Stormpath.AspNet;

namespace AppServer2.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            // Stormpath Client and Account can be pulled from the request
            //var client = Request.GetStormpathClient();
            //var account = Request.GetStormpathAccount();
            //var configuration = Request.GetStormpathConfiguration();
            //var application = Request.GetStormpathApplication();

            return new [] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
