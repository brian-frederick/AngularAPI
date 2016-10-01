using AngularAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularAPI.Controllers
{
    public class ReviewsController : ApiController
    {
        // POST api/values
        public void Post([FromBody]ProductModel value)
        {
            //TODO: Save this to a database next week
        }
    }
}
