using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ContactHubAPI.Models.User;
using System.Security.Claims;

namespace ContactHubAPI.Controllers
{
    [Authorize]
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {
        [HttpPost]
        [Route("authorizeUser")]
        public HttpResponseMessage AuthorizeUser(LoginUser model)
        {
            if(!string.IsNullOrEmpty(model.Username) && !string.IsNullOrEmpty(model.Password))
            {
                Redirect(new Uri("/api/token"));
            }
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
