using Microsoft.AspNetCore.Mvc;

namespace HelloWorld2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorld3Controller : ControllerBase
    {

        [HttpGet(Name = "GetHelloWorld3")]
        public string Get()
        {
            return "Hello Ziraat Team from " + Environment.GetEnvironmentVariable("USER");
        }
    }
}
