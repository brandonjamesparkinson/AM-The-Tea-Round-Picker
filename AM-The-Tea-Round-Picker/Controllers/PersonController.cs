using AM_The_Tea_Round_Picker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AM_The_Tea_Round_Picker.Controllers
{
    public class PersonController : Controller
    {
        private TeaPickerDbEntities objTeaPickerDbEntities;

        public PersonController()
        {
            objTeaPickerDbEntities = new TeaPickerDbEntities();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreatePerson(Person model)
        {

            return View();
        }

        [HttpPut]
        public ActionResult EditPerson(Person model)
        {

            return View();
        }

        [HttpGet]
        public ActionResult GetPeople(List<Person> listOfPeople)
        {

            return View();
        }

        [HttpGet]
        public ActionResult GetPersonById(int id)
        {

            return View();
        }

        [HttpDelete]
        public ActionResult DeletePerson(int id)
        {

            return View();
        }
    }
}