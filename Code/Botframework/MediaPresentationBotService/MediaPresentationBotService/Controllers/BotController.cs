using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MediaPresentationBotService.Controllers
{/// <summary>
/// This class handles the basic back-end service functionality used by the bots 
/// </summary>
    public class BotController : ApiController
    {
        // GET: api/Bot
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Bot/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Bot
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Bot/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Bot/5
        public void Delete(int id)
        {
        }
    }
}
