using Microsoft.Extensions.Logging.Abstractions;
using Notedu.QNAA.Controllers.V1;
using Notedu.QNAA.Models;
using Notedu.QNAA.Models.V1.Questions;
using System.Collections.Generic;
using Xunit;

namespace Notedu.QNAA.UnitTest.V1
{
    public class QuestionsControllerUnitTest
    {
        private NullLogger<QuestionsController> mockLogger;
        private QuestionsController controller;

        public QuestionsControllerUnitTest()
        {
            mockLogger = new NullLogger<QuestionsController>();
            controller = new QuestionsController(mockLogger);
        }
        [Fact]
        public void GetTest()
        {
            var question = controller.Get(1);

            Assert.IsType<QuestionModel>(question);
        }
        
        [Fact]
        public void GetHistoryTest()
        {
            var history = controller.GetHistory(1);

            Assert.IsType<List<QuestionModel>>(history);
        }
        
        [Fact]
        public void GetByUserTest()
        {
            var question = controller.GetByUser(1);

            Assert.IsType<QuestionModel>(question);
        }


        [Fact]
        public void GetByTagTest()
        {
            var question = controller.GetByTag(1);

            Assert.IsType<QuestionModel>(question);
        }

        [Fact]
        public void CreateTest()
        {
            var question = controller.Create(new QuestionModel());

            Assert.IsType<QuestionModel>(question);
        }
        
        [Fact]
        public void UpdateTest()
        {
            var question = controller.Update(new QuestionModel());

            Assert.IsType<QuestionModel>(question);
        }
        
        [Fact]
        public void AcceptTest()
        {
            var question = controller.Accept(1);

            Assert.IsType<QuestionModel>(question);
        }
        
        [Fact]
        public void ReportTest()
        {
            var question = controller.Report(1);

            Assert.IsType<QuestionModel>(question);
        }
        
        [Fact]
        public void UpvoteTest()
        {
            var question = controller.Upvote(1);

            Assert.IsType<QuestionModel>(question);
        }

        [Fact]
        public void DownVoteTest()
        {
            var question = controller.DownVote(1);

            Assert.IsType<QuestionModel>(question);
        }

        [Fact]
        public void GetFavoritesTest()
        {
            var question = controller.GetFavorites(1);

            Assert.IsType<List<QuestionModel>>(question);
        }

        [Fact]
        public void AddToFavoritesTest()
        {
            var question = controller.AddToFavorites(1);

            Assert.IsType<BaseModel>(question);
        }

        [Fact]
        public void SoftDeleteTest()
        {
            var question = controller.SoftDelete(1);

            Assert.IsType<QuestionModel>(question);
        }
        
        [Fact]
        public void HardGetTest()
        {
            var question = controller.HardDelete(1);

            Assert.IsType<QuestionModel>(question);
        }
    }
}
