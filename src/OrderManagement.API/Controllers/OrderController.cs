using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderManagement.Domain.Models;
using System.IO;
using System.Net;
using System.Net.Http;

namespace OrderManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpPost("CreatOrder")]
        public Order CreatOrder(Order order)
        {
            return new Order();
        }
        [HttpPost("UploadImage")]
        public void UploadImage(IFormFile file)
        {
            string workingDirectory = Directory.GetCurrentDirectory();
            FileStream streams = new(workingDirectory+file.FileName, FileMode.Create);
            file.CopyTo(streams);
            streams.Close();
        }

        [HttpPost("CreateOrderWithId")]
        public Order CreateOrderWithId(int id, Order order)
        {
            return new Order();
        }
        [HttpPost("CreateOrderWithIdWithImage")]
        public Order CreateOrderWithId([FromForm]OrderParameter orderParameter)
        {
            return new Order();
        }
    }
}
