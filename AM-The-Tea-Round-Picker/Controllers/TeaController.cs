using AM_The_Tea_Round_Picker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AM_The_Tea_Round_Picker.Controllers
{
    public class TeaController : Controller
    {
        private TeaPickerDbEntities objTeaPickerDbEntities;

        public TeaController()
        {
            objTeaPickerDbEntities = new TeaPickerDbEntities();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateTea(Tea model)
        {

            return View();
        }

        [HttpPut]
        public ActionResult EditTea(Tea model)
        {

            return View();
        }

        [HttpGet]
        public ActionResult GetTea(List<Tea> listofTea)
        {

            return View();
        }

        [HttpGet]
        public ActionResult GetTeaById(int id)
        {

            return View();
        }

        [HttpDelete]
        public ActionResult DeleteTea(int id)
        {
            
            return View();
        }
    }
}