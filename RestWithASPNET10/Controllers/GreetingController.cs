using Microsoft.AspNetCore.Mvc;
using RestWithASPNET10.Model;


namespace RestWithASPNET10.Controllers{
   
        [ApiController]
        [Route("[controller]")]
        public class GreetingController : ControllerBase
        {
            private static long counter = 0;
            private static readonly string template = "Hello, {0}!";


            [HttpGet]
            public Greeting Get([FromQuery] string name = "world")
            {
                var id = Interlocked.Increment(ref counter);
                var content = string.Format(template, name);
                return new Greeting(1,content);
            }
        }
    
}
