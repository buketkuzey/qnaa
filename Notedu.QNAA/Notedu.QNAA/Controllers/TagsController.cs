using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Notedu.QNAA.Models;

namespace Notedu.QNAA.Controllers
{
    [ApiController]
    [Route("[controller]")]
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
        public TagModel Delete(int id)
        {
            return new TagModel();
        }
    }
}
