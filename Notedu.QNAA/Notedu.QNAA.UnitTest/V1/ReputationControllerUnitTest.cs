using Microsoft.Extensions.Logging.Abstractions;
using Notedu.QNAA.Controllers.V1;
using Notedu.QNAA.Models;
using Notedu.QNAA.Models.V1.Reputation;
using System.Collections.Generic;
using Xunit;

namespace Notedu.QNAA.UnitTest.V1
{
    public class ReputationControllerUnitTest
    {
        private NullLogger<ReputationController> mockLogger;
        private ReputationController controller;

        public ReputationControllerUnitTest()
        {
            mockLogger = new NullLogger<ReputationController>();
            controller = new ReputationController(mockLogger);
        }
        [Fact]
        public void GetReputationsTest()
        {
            var reputation = controller.GetReputations();

            Assert.IsType<List<ReputationModel>>(reputation);
        }
        
        [Fact]
        public void AddReputationTest()
        {
            var response = controller.AddReputation(new ReputationModel());

            Assert.IsType<BaseModel>(response);
        }
        
        [Fact]
        public void GetBadgesTest()
        {
            var reputations = controller.GetBadges();

            Assert.IsType<List<ReputationModel>>(reputations);
        }

        [Fact]
        public void AddBadgeTest()
        {
            var response = controller.AddBadge(new BadgeModel());

            Assert.IsType<BaseModel>(response);
        }
    }
}
