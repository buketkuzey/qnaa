using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Notedu.QNAA.Models.V1.Tags;


namespace Notedu.QNAA.Controllers.V1
{
    [ApiController]
    [Route("v1.0/[controller]")]
    public class TagsController : ControllerBase
    {
        private readonly ILogger<TagsController> _logger;
  

        public TagsController(ILogger<TagsController> logger)
        {
            _logger = logger;
          
        }

        [HttpGet]
        public TagModel Get(int id)
        {
            return new TagModel();
        }

        [HttpPost]
        public TagModel Create(TagModel model)
        {
            return new TagModel();
        }

        [HttpPost]
        public TagModel Update(TagModel model)
        {
            return new TagModel();
        }

        [HttpDelete]
        public TagModel SoftDelete(int id)
        {
            return new TagModel();
        }

        [HttpDelete]
        public TagModel HardDelete(int id)
        {
            return new TagModel();
        }
    }
}
