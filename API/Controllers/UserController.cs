using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API.Controllers
{
    [EnableCors("*","*","*")]
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {
        
        [Route("GetNumOfUsers")]
        [HttpGet]
        public IHttpActionResult GetNumOfUsers()
        {
            return Ok(1);
        }

        [Route("GetNumOfproduct/{numOfP}")]
        [HttpGet]
        public int GetNumOfproduct(int numOfP)
        {
            return numOfP;
        }

       [ Route("AddUser"), HttpPost]
        public IHttpActionResult AddUser(userDTO user)
        {
            BL.userBL.AddUser(user);
            return Ok(true);
        }

    }
}
