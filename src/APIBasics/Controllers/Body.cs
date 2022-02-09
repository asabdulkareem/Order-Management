using Microsoft.AspNetCore.Http;

namespace APIBasics.Controllers
{
    public class Body
    {
        public IFormFile MyProperty { get; set; }
        public string Name { get; set; }
    }
}