using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bonfml_back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestApiController : ControllerBase
    {
        private readonly ILogger<TestApiController> _logger;

        public TestApiController(ILogger<TestApiController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public string Get()
        {
            return "Success!";
        }
    }
}
