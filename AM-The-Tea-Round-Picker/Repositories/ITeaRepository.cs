using AM_The_Tea_Round_Picker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AM_The_Tea_Round_Picker.Repositories
{
    public interface ITeaRepository
    {
        IEnumerable<SelectListItem> GetAllTeaType();
        IEnumerable<Tea> GetAll();
        Tea GetById(int teaId);
        void AddTea(Tea tea);
        //void Update(Tea tea);
        void Delete(int id);
    }
}
