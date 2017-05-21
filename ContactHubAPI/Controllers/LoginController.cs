using System.Net;
using System.Net.Http;
using System.Web.Http;
using ContactHubAPI.Models.User;
using ContactHubAPI.BusinessService;

namespace ContactHubAPI.Controllers
{
    [RoutePrefix("api/anonymous")]
    public class LoginController : ApiController
    {
        [Route("signin")]
        [HttpPost]
        public IHttpActionResult UserSignin(LoginUserViewModel model)
        {
            return Ok(model);
        }

        [Route("signup")]
        [HttpPost]
        public HttpResponseMessage UserSignup(RegisterUser model)
        {
            var result = BusinessServiceFacade<RegisterUser>.BusinessUserManager.CreateNewUser(model);
            if (result == null) {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            return Request.CreateResponse(HttpStatusCode.OK,result);
        }
    }
}
