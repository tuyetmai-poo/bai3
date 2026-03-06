using Microsoft.AspNetCore.Mvc;

namespace Bai2.Controllers
{
    public class Greeting : Controller
    {
        [Route("")]
        public string Greetings() => $"Welcome to ..";
        [Route("hi")]
        public string Hii() => $"Hithere..";
        [Route("hello/{name}")]
        public string Hello(string name) => $"Hello, {name}";

    }
}
