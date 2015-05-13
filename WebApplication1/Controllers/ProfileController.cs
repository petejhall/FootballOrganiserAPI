using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;
using WebApplication1.Repository;
using System.Web.Routing;
namespace WebApplication1.Controllers
{
    [RoutePrefix("api/PetesProfile")]
    public class ProfileController : ApiController
    {

        public string[] get()
        {
            return new string[] { "pete", "hall" };

        }

        [HttpGet]
        [Route("getMyProfile/{id}")]
        public Profile[] get(int id)
        {
          return  new CustomerProfileRepository().GetMyData(2323);

        }

        public void PostMyData([FromBody] string myValues)
        {

        }

    }
}
