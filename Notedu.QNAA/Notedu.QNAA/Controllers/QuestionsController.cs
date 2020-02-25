using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Notedu.QNAA.Models;
using Notedu.QNAA.Models.Questions;

namespace Notedu.QNAA.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionsController : ControllerBase
    {

        private readonly ILogger<QuestionsController> _logger;

        public QuestionsController(ILogger<QuestionsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public QuestionModel Get(int id)
        {
            return new QuestionModel();
        }

        [HttpGet]
        public List<QuestionModel> GetHistory(int id)
        {
            return new List<QuestionModel>();
        }

        [HttpGet]
        public QuestionModel GetByUser(int userId)
        {
            return new QuestionModel();
        }


        [HttpGet]
        public QuestionModel GetByTag(int tagId)
        {
            return new QuestionModel();
        }

        [HttpPost]
        public QuestionModel Create(QuestionModel model)
        {
            return new QuestionModel();
        }

        [HttpPost]
        public QuestionModel Update(QuestionModel model)
        {
            return new QuestionModel();
        }

        [HttpPost]
        public QuestionModel Accept(int questionId)
        {
            return new QuestionModel();
        }

        [HttpPost]
        public QuestionModel Report(int questionId)
        {
            return new QuestionModel();
        }

        [HttpPost]
        public QuestionModel Upvote(int questionId)
        {
            return new QuestionModel();
        }

        [HttpPost]
        public QuestionModel DownVote(int questionId)
        {
            return new QuestionModel();
        }

        [HttpPost]
        public List<QuestionModel> GetFavorites(int questionId)
        {
            return new List<QuestionModel>();
        }

        [HttpPost]
        public BaseModel AddToFavorites(int questionId)
        {
            return new BaseModel();
        }


        [HttpDelete]
        public QuestionModel Delete(int id)
        {
            return new QuestionModel();
        }
    }
}
