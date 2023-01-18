using AM_The_Tea_Round_Picker.Models;
using AM_The_Tea_Round_Picker.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AM_The_Tea_Round_Picker.Controllers
{
    public class HomeController : Controller
    {
        private TeaPickerDbEntities objTeaPickerDbEntities;

        public HomeController()
        {
            objTeaPickerDbEntities = new TeaPickerDbEntities();
        }

        public ActionResult Index()
        {
            PersonRepository objPersonRepository = new PersonRepository();
            TeaRepository objTeaRepository = new TeaRepository();
            TeaMakerRepository objTeaMakerRepository = new TeaMakerRepository();

            //todo: teamaker stuff for analytics and tracking
            //var objMultipleModels = new Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>, IEnumerable<SelectListItem>>
            //    (objPersonRepository.GetAllPeople(), objTeaRepository.GetAllTeaType(), objTeaMakerRepository.GetAllTeaMakers());

            var objMultipleModels = new Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>>
                (objPersonRepository.GetAllPeople(), objTeaRepository.GetAllTeaType());

            //ViewBag.MyString = RandomTeaMaker();

            return View(objMultipleModels);
        }

        //public string RandomTeaMaker()
        //{
        //    PersonRepository objPersonRepository = new PersonRepository();
        //    var random = new Random();
        //    var potentialTeaMakers = objPersonRepository.GetAllPeople();
        //    string teaMaker = string.Empty;


        //    int index = random.Next(0, potentialTeaMakers);
        //    teaMaker = objPersonRepository.GetPerson(index);

        //    //var randomTeaMakerId = random.Next(0, potentialTeaMakers.Value);

        //    //string teaMaker = objPersonRepository.GetPerson(randomTeaMakerId);

        //    return teaMaker;
        //}
    }
}