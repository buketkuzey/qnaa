﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Notedu.QNAA.Models;

namespace Notedu.QNAA.Controllers
{
    [ApiController]
    [Route("[controller]")]
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
        public CommentModel Delete(int id)
        {
            return new CommentModel();
        }
    }
}