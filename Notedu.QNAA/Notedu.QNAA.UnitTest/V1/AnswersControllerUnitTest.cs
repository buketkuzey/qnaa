using Microsoft.Extensions.Logging.Abstractions;
using Notedu.QNAA.Controllers.V1;
using Notedu.QNAA.Models.V1.Answers;
using System.Collections.Generic;
using Xunit;

namespace Notedu.QNAA.UnitTest.V1
{
    public class AnswersControllerUnitTest
    {
        private NullLogger<AnswersController> mockLogger;
        private AnswersController controller;

        public AnswersControllerUnitTest()
        {
            mockLogger = new NullLogger<AnswersController>();
            controller = new AnswersController(mockLogger);
        }
        [Fact]
        public void GetTest()
        {
            var answer = controller.Get(1);

            Assert.IsType<AnswerModel>(answer);
        }
        
        [Fact]
        public void GetHistoryTest()
        {
            var history = controller.GetHistory(1);

            Assert.IsType<List<AnswerModel>>(history);
        }
        
        [Fact]
        public void GetByUserTest()
        {
            var answer = controller.GetByUser(1);

            Assert.IsType<AnswerModel>(answer);
        }
        
        [Fact]
        public void CreateTest()
        {
            var answer = controller.Create(new AnswerModel());

            Assert.IsType<AnswerModel>(answer);
        }
        
        [Fact]
        public void UpdateTest()
        {
            var answer = controller.Update(new AnswerModel());

            Assert.IsType<AnswerModel>(answer);
        }
        
        [Fact]
        public void ReportTest()
        {
            var answer = controller.Report(1);

            Assert.IsType<AnswerModel>(answer);
        }
        
        [Fact]
        public void UpvoteTest()
        {
            var answer = controller.Upvote(1);

            Assert.IsType<AnswerModel>(answer);
        }
        
        [Fact]
        public void DownVoteTest()
        {
            var answer = controller.DownVote(1);

            Assert.IsType<AnswerModel>(answer);
        }
        
        [Fact]
        public void SoftDeleteTest()
        {
            var answer = controller.SoftDelete(1);

            Assert.IsType<AnswerModel>(answer);
        }
        
        [Fact]
        public void HardGetTest()
        {
            var answer = controller.HardDelete(1);

            Assert.IsType<AnswerModel>(answer);
        }
    }
}
