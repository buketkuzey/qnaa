using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Notedu.QNAA.Models.V1.Comments;

namespace Notedu.QNAA.Controllers.V1
{
    [ApiController]
    [Route("v1.0/[controller]")]
    public class CommentsController : ControllerBase
    {

        private readonly ILogger<CommentsController> _logger;

        public CommentsController(ILogger<CommentsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public CommentModel Get(int id)
        {
            return new CommentModel();
        }

        [HttpGet]
        public List<CommentModel> GetHistory(int id)
        {
            return new List<CommentModel>();
        }

        [HttpGet]
        public CommentModel GetByUser(int userId)
        {
            return new CommentModel();
        }

        [HttpPost]
        public CommentModel Create(CommentModel model)
        {
            return new CommentModel();
        }

        [HttpPost]
        public CommentModel Update(CommentModel model)
        {
            return new CommentModel();
        }

        [HttpPost]
        public CommentModel Report(int questionId)
        {
            return new CommentModel();
        }

        [HttpPost]
        public CommentModel Upvote(int questionId)
        {
            return new CommentModel();
        }

        [HttpPost]
        public CommentModel DownVote(int questionId)
        {
            return new CommentModel();
        }


        [HttpDelete]
        public CommentModel SoftDelete(int id)
        {
            return new CommentModel();
        }

        [HttpDelete]
        public CommentModel HardDelete(int id)
        {
            return new CommentModel();
        }
    }
}
