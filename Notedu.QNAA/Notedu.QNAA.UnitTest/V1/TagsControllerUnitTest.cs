using Microsoft.Extensions.Logging.Abstractions;
using Notedu.QNAA.Controllers.V1;
using Notedu.QNAA.Models.V1.Tags;
using Xunit;

namespace Notedu.QNAA.UnitTest.V1
{
    public class TagsControllerUnitTest
    {
        private NullLogger<TagsController> mockLogger;
        private TagsController controller;

        public TagsControllerUnitTest()
        {
            mockLogger = new NullLogger<TagsController>();
            controller = new TagsController(mockLogger);
        }

        [Fact]
        public void GetTest()
        {
            var tag = controller.Get(1);

            Assert.IsType<TagModel>(tag);
        }
        
        [Fact]
        public void CreateTest()
        {
            var tag = controller.Create(new TagModel());

            Assert.IsType<TagModel>(tag);
        }
        
        [Fact]
        public void UpdateTest()
        {
            var tag = controller.Update(new TagModel());

            Assert.IsType<TagModel>(tag);
        }
        
        [Fact]
        public void SoftDeleteTest()
        {
            var tag = controller.SoftDelete(1);

            Assert.IsType<TagModel>(tag);
        }
        
        [Fact]
        public void HardGetTest()
        {
            var tag = controller.HardDelete(1);

            Assert.IsType<TagModel>(tag);
        }
    }
}
