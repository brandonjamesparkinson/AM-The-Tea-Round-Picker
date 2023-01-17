using AM_The_Tea_Round_Picker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AM_The_Tea_Round_Picker.Repositories
{
    public class PersonRepository
    {
        private TeaPickerDbEntities objTeaPickerDbEntities;

        public PersonRepository()
        {
            objTeaPickerDbEntities = new TeaPickerDbEntities();
        }

        public IEnumerable<SelectListItem> GetAllPeople()
        {
            var objSelectListItems = new List<SelectListItem>();

            objSelectListItems = (from obj in objTeaPickerDbEntities.People
                                  select new SelectListItem()
                                  {
                                      Text = obj.PersonName,
                                      Value = obj.PersonId.ToString(),
                                      Selected = true
                                  }).ToList();

            return objSelectListItems;
        }

        public string GetPerson(int personId)
        {
            string person = objTeaPickerDbEntities.People.SingleOrDefault(x => x.PersonId == personId).PersonName;

            return person;
        }
    }
}