using System.Web.Mvc;
using VideoStoreUI.Models;

namespace VideoStoreUI.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person/Random
        public ActionResult Random()
        {
            var person = new PersonModel() { Name = "Hello World!" };
            return View(person);
        }
    }
}