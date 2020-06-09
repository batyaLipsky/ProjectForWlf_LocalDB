using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    [RoutePrefix("api/users")]
    public class UserController : ApiController
    {
        [HttpGet]  
        [Route("Users")]

        public IHttpActionResult GetUsers()
        {

            return Ok(BL.UserBL.GetUsers());
           // return Ok( "dd");
        }


        //that method is also correct, even though it doesn't have [Route("Users")]
        [HttpGet]
        public IHttpActionResult Login()
        {
            return Ok("correct method");
        }
    }
}
