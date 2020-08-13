using Microsoft.Extensions.Logging.Abstractions;
using Notedu.QNAA.Controllers.V1;
using Notedu.QNAA.Models.V1.User;
using Xunit;

namespace Notedu.QNAA.UnitTest.V1
{
    public class UserControllerUnitTest
    {
        private NullLogger<UserController> mockLogger;
        private UserController controller;

        public UserControllerUnitTest()
        {
            mockLogger = new NullLogger<UserController>();
            controller = new UserController(mockLogger);
        }

        [Fact]
        public void GetTest()
        {
            var user = controller.Get(1);

            Assert.IsType<UserModel>(user);
        }
        
        [Fact]
        public void CreateTest()
        {
            var user = controller.Create(new UserModel());

            Assert.IsType<UserModel>(user);
        }
        
        [Fact]
        public void UpdateTest()
        {
            var user = controller.Update(new UserModel());

            Assert.IsType<UserModel>(user);
        }
        
        [Fact]
        public void SoftDeleteTest()
        {
            var user = controller.SoftDelete(1);

            Assert.IsType<UserModel>(user);
        }
        
        [Fact]
        public void HardGetTest()
        {
            var user = controller.HardDelete(1);

            Assert.IsType<UserModel>(user);
        }


        [Fact]
        public void AuthTest()
        {
            var user = controller.Auth(new AuthModel());

            Assert.IsType<UserModel>(user);
        }
    }
}
