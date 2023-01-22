using AM_The_Tea_Round_Picker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AM_The_Tea_Round_Picker.Repositories
{
    public interface IPersonRepository
    {
        IEnumerable<SelectListItem> GetAllPeople();
        IEnumerable<Person> GetAll();
        Person GetById(int personId);
        void AddPerson(Person person);
        //void Update(Person person);
        void Delete(int id);

    }
}
