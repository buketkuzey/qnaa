using Microsoft.Extensions.Logging.Abstractions;
using Notedu.QNAA.Controllers.V1;
using Notedu.QNAA.Models.V1.Comments;
using System.Collections.Generic;
using Xunit;

namespace Notedu.QNAA.UnitTest.V1
{
    public class CommentsControllerUnitTest
    {
        private NullLogger<CommentsController> mockLogger;
        private CommentsController controller;

        public CommentsControllerUnitTest()
        {
            mockLogger = new NullLogger<CommentsController>();
            controller = new CommentsController(mockLogger);
        }
        [Fact]
        public void GetTest()
        {
            var comment = controller.Get(1);

            Assert.IsType<CommentModel>(comment);
        }
        
        [Fact]
        public void GetHistoryTest()
        {
            var history = controller.GetHistory(1);

            Assert.IsType<List<CommentModel>>(history);
        }
        
        [Fact]
        public void GetByUserTest()
        {
            var comment = controller.GetByUser(1);

            Assert.IsType<CommentModel>(comment);
        }
        
        [Fact]
        public void CreateTest()
        {
            var comment = controller.Create(new CommentModel());

            Assert.IsType<CommentModel>(comment);
        }
        
        [Fact]
        public void UpdateTest()
        {
            var comment = controller.Update(new CommentModel());

            Assert.IsType<CommentModel>(comment);
        }
        
        [Fact]
        public void ReportTest()
        {
            var comment = controller.Report(1);

            Assert.IsType<CommentModel>(comment);
        }
        
        [Fact]
        public void UpvoteTest()
        {
            var comment = controller.Upvote(1);

            Assert.IsType<CommentModel>(comment);
        }
        
        [Fact]
        public void DownVoteTest()
        {
            var comment = controller.DownVote(1);

            Assert.IsType<CommentModel>(comment);
        }
        
        [Fact]
        public void SoftDeleteTest()
        {
            var comment = controller.SoftDelete(1);

            Assert.IsType<CommentModel>(comment);
        }
        
        [Fact]
        public void HardGetTest()
        {
            var comment = controller.HardDelete(1);

            Assert.IsType<CommentModel>(comment);
        }
    }
}
