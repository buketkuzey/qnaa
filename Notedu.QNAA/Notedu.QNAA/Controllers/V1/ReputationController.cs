using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Notedu.QNAA.Models;
using Notedu.QNAA.Models.V1.Reputation;
using System.Collections.Generic;

namespace Notedu.QNAA.Controllers.V1
{
    [ApiController]
    [Route("v1.0/[controller]")]
    public class ReputationController : ControllerBase
    {

        private readonly ILogger<ReputationController> _logger;

        public ReputationController(ILogger<ReputationController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<ReputationModel> GetReputations()
        {
            return new List<ReputationModel>();
        }

        [HttpGet]
        public BaseModel AddReputation(ReputationModel model)
        {
            return new BaseModel();
        }

        [HttpGet]
        public List<ReputationModel> GetBadges()
        {
            return new List<ReputationModel>();
        }

        [HttpGet]
        public BaseModel AddBadge(BadgeModel model)
        {
            return new BaseModel();
        }
    }
}
