using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Tungnt.NET.WebAPIHTTP.Controllers
{
    public class DefaultController : ApiController
    {
        /// <summary>
        /// Returns all values.
        /// </summary>
        /// <returns>String array.</returns>
        public IHttpActionResult Values()
        {
            return Ok(new string[] { "value1", "value2" });
        }
    }
}
