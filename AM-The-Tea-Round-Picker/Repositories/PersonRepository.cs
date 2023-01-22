using AM_The_Tea_Round_Picker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AM_The_Tea_Round_Picker.Repositories
{
    public class PersonRepository : IPersonRepository
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

        public IEnumerable<Person> GetAll()
        {
            return objTeaPickerDbEntities.People.ToList();
        }

        public Person GetById(int personId)
        {
            return objTeaPickerDbEntities.People.Find(personId);
        }

        public void AddPerson(Person person)
        {
            objTeaPickerDbEntities.People.Add(person);
            objTeaPickerDbEntities.SaveChanges();
        }

        //todo: edit person (name etc)
        //public void Update(Person person)
        //{

        //}

        public void Delete(int id)
        {
            var person = objTeaPickerDbEntities.People.Find(id);
            objTeaPickerDbEntities.People.Remove(person);
            objTeaPickerDbEntities.SaveChanges();
        }
    }
}