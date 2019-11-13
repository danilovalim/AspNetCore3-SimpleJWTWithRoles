using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtSimpleApp.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class EmployeesController : ControllerBase
    {
        [HttpGet]
        [Route("types")]
        [Authorize]
        public string Types()
        {
            return "manager, worker";
        }

        [HttpGet]
        [Route("manager")]
        [Authorize(Roles = "manager")]
        public string GetManager()
        {
            return "manager returned...";
        }

        [HttpGet]
        [Route("worker")]
        [Authorize(Roles = "worker")]
        public string GetWorker()
        {
            return "worker returned...";
        }
    }
}