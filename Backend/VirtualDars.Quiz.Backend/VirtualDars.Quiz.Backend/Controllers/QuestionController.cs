using Microsoft.AspNetCore.Mvc;
using VirtualDars.Quiz.Backend.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VirtualDars.Quiz.Backend.Controllers
{
    [Route("api/[controller]")]
    public class QuestionController : Controller
    {
        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody] Question question)
        {

        }       
    }
}
