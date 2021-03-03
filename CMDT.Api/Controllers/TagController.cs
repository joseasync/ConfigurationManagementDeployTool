using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMDT.Domain.Models;
using CMDT.Domain.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CMDT.Api.Controllers
{
    [ApiController]
    public class TagController : ControllerBase
    {
        private readonly ILogger<TagController> _logger;
        private IList<Tag> _myTags;

        public TagController(ILogger<TagController> logger)
        {
            _myTags = new List<Tag>
            { 
                new Tag{
                    Id = "Generic Id - 1",
                    Customer = "Generic Customer",
                    Environment = "Generic Enviroment",
                    ReleaseDate = DateTime.Now
                },
                
                new Tag{
                    Id = "Generic Id - 1",
                    Customer = "Generic Customer",
                    Environment = "Generic Enviroment",
                    ReleaseDate = DateTime.Now
                },
                
                new Tag{
                    Id = "Generic Id - 1",
                    Customer = "Generic Customer",
                    Environment = "Generic Enviroment",
                    ReleaseDate = DateTime.Now
                }
            };
            _logger = logger;
        }

        [HttpGet(RoutesManagement.Tag.GetTag)]
        public async Task<ActionResult> GetTag()
        {
            return Ok(_myTags);
        }
    }
}
