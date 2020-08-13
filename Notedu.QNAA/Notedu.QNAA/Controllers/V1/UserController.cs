using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Notedu.QNAA.Models.V1.User;

namespace Notedu.QNAA.Controllers.V1
{
    [ApiController]
    [Route("v1.0/[controller]")]
    public class UserController : ControllerBase
    {

        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public UserModel Get(int id)
        {
            return new UserModel();
        }

        [HttpPost]
        public UserModel Create(UserModel model)
        {
            return new UserModel();
        }

        [HttpPost]
        public UserModel Update(UserModel model)
        {
            return new UserModel();
        }

        [HttpDelete]
        public UserModel SoftDelete(int id)
        {
            return new UserModel();
        }

        [HttpDelete]
        public UserModel HardDelete(int id)
        {
            return new UserModel();
        }

        [HttpPost]
        public UserModel Auth(AuthModel model)
        {
            return new UserModel();
        }
    }
}
