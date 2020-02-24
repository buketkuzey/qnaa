using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Notedu.QNAA.Models.User;

namespace Notedu.QNAA.Controllers
{
    [ApiController]
    [Route("[controller]")]
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
        public UserModel Delete(int id)
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
