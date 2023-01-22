using AM_The_Tea_Round_Picker.Models;
using AM_The_Tea_Round_Picker.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AM_The_Tea_Round_Picker.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonRepository _personRepository;

        public PersonController()
        {
            _personRepository = new PersonRepository();
        }

        public ActionResult Index()
        {
            var people = _personRepository.GetAll();
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
                _personRepository.AddPerson(person);
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
        public ActionResult DeletePerson(int personId)
        {
            _personRepository.Delete(personId);
            return RedirectToAction("Index");
        }
    }
}