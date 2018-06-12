using System.Threading.Tasks;
using Business;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("[controller]")]
    public class PeopleController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var allPeople = new People().AllPeople();

            return Json(allPeople);
        }
    }
}
