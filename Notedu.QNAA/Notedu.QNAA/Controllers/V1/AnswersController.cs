using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Notedu.QNAA.Models.V1.Answers;

namespace Notedu.QNAA.Controllers.V1
{
    [ApiController]
    [Route("v1.0/[controller]")]
    public class AnswersController : ControllerBase
    {

        private readonly ILogger<AnswersController> _logger;

        public AnswersController(ILogger<AnswersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public AnswerModel Get(int Id)
        {
            return new AnswerModel();
        }

        [HttpGet]
        public List<AnswerModel> GetHistory(int Id)
        {
            return new List<AnswerModel>();
        }

        [HttpGet]
        public AnswerModel GetByUser(int UserId)
        {
            return new AnswerModel();
        }


        [HttpPost]
        public AnswerModel Create(AnswerModel model)
        {
            return new AnswerModel();
        }

        [HttpPost]
        public AnswerModel Update(AnswerModel model)
        {
            return new AnswerModel();
        }

        [HttpPost]
        public AnswerModel Report(int Id)
        {
            return new AnswerModel();
        }

        [HttpPost]
        public AnswerModel Upvote(int Id)
        {
            return new AnswerModel();
        }

        [HttpPost]
        public AnswerModel DownVote(int Id)
        {
            return new AnswerModel();
        }

        [HttpDelete]
        public AnswerModel SoftDelete(int Id)
        {
            return new AnswerModel();
        }


        [HttpDelete]
        public AnswerModel HardDelete(int Id)
        {
            return new AnswerModel();
        }
    }
}
