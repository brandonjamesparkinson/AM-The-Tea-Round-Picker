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
            var people = objTeaPickerDbEntities.People;
            return View(people);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Person person)
        {
            if (ModelState.IsValid)
            {
                objTeaPickerDbEntities.People.Add(person);
                objTeaPickerDbEntities.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(person);
        }

        //[HttpPut]
        //public ActionResult EditPerson(Person model)
        //{

        //    return View();
        //}

        [HttpDelete]
        public ActionResult DeletePerson(int id)
        {

            return View();
        }
    }
}