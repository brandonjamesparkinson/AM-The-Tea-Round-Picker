using AM_The_Tea_Round_Picker.Models;
using AM_The_Tea_Round_Picker.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AM_The_Tea_Round_Picker.Controllers
{
    public class TeaController : Controller
    {
        private readonly ITeaRepository _teaRepository;

        public TeaController()
        {
            _teaRepository = new TeaRepository();
        }

        public ActionResult Index()
        {
            var tea = _teaRepository.GetAll();
            return View(tea);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Tea tea)
        {
            if (ModelState.IsValid)
            {
                _teaRepository.AddTea(tea);
                return RedirectToAction("Index");
            }
            return View(tea);
        }
    }
}