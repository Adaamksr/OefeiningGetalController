using Grpc.Core;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using System.IO;
using System;

namespace OefeiningGetalController.Controllers
{
        [ApiController]
        [Route("[controller]")]
    public class GetalController : Controller
    {
        public GetalController()
        {

        }

        [HttpGet("ReadInFile")]
        public ActionResult<string> ReadFile()
        {
            try
            {
                string[] InFiles = System.IO.File.ReadAllLines(@"C:\Users\adamk\source\repos\OefeiningGetalController\getal.txt");
                return Ok(InFiles);
            }
            catch (IOException e)
            {
                return NotFound();
            }
        }

        [HttpPost("WriteInFile")]
        public ActionResult WriteFile(int getal)
        {
            string getalstring = Convert.ToString(getal);
            try
            {
                System.IO.File.WriteAllText(@"C:\Users\adamk\source\repos\OefeiningGetalController\getal.txt", getalstring);
                return Ok();
            }
            catch (IOException e)
            {
                return NotFound();
            }
        }

        [HttpPost("RandomPicker")]
        public ActionResult Random()
        {
            Random Number = new Random();
            string getalstring = Convert.ToString(Number.Next(0, 10));
            try
            {
                System.IO.File.WriteAllText(@"C:\Users\adamk\source\repos\OefeiningGetalController\getal.txt", getalstring);
                return Ok();
            }
            catch (IOException e)
            {
                return NotFound();
            }
        }
    }
}
