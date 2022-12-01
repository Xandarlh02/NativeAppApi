using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.Text;
using System.IO;
using ImageService = NativeAppApi.Services.ImageService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NativeAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        // GET: api/<ImagesController>
        [HttpGet]
        [Route("GetImages")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ImagesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ImagesController>
        [HttpPost]
		[Route("PostImage")]
		public void Post(string value)
        {
            ImageService imageService = new ImageService();
            imageService.AddImageToFolder(value);

        }

        // PUT api/<ImagesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ImagesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
