using System.Collections.Generic;
using System.Web.Mvc;
using VideoStoreUI.Models;

namespace VideoStoreUI.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person/Random
        public ActionResult Random()
        {
            var person = new PersonModel() { Name = "Jack" };
            var friends = new List<Friend>
            {
                new Friend() {Id = 1,Name = "Tim"},
                new Friend() {Id = 2, Name = "Sue"}
            };

            var viewModel = new RandomPersonViewModel()
            {
                PersonModel = person,
                Friends = friends
            };

            return View(viewModel);
        }
        [Route("person/edit/{id:regex(\\d)}")]
        public ActionResult Edit(int id)
        {
            var person = new PersonModel() { Name = "Jack" };
            var friends = new List<Friend>
            {
                new Friend() {Id = 1,Name = "Tim"},
                new Friend() {Id = 2, Name = "Sue"}
            };

            var viewModel = new PersonModel()
            {
                Id = id - 1,
                Name = friends[id - 1].Name
            };
            return View(viewModel);
        }
        //person/bybirthday
        [Route("person/bybirthday/{year:regex(\\d{4})}/{month:regex(\\d{2})}")]
        public ActionResult ByBirthday(int year, int month)
        {
            return Content(year + "/" + month);
        }


    }
}