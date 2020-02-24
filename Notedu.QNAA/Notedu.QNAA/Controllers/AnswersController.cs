using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Notedu.QNAA.Models.Answers;

namespace Notedu.QNAA.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnswersController : ControllerBase
    {

        private readonly ILogger<AnswersController> _logger;

        public AnswersController(ILogger<AnswersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public AnswerModel Get(int id)
        {
            return new AnswerModel();
        }

        [HttpGet]
        public List<AnswerModel> GetHistory(int id)
        {
            return new List<AnswerModel>();
        }

        [HttpGet]
        public AnswerModel GetByUser(int userId)
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
        public AnswerModel Report(int questionId)
        {
            return new AnswerModel();
        }

        [HttpPost]
        public AnswerModel Upvote(int questionId)
        {
            return new AnswerModel();
        }

        [HttpPost]
        public AnswerModel DownVote(int questionId)
        {
            return new AnswerModel();
        }


        [HttpDelete]
        public AnswerModel Delete(int id)
        {
            return new AnswerModel();
        }
    }
}
