using AM_The_Tea_Round_Picker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AM_The_Tea_Round_Picker.Repositories
{

    public class TeaRepository
    {
        private TeaPickerDbEntities objTeaPickerDbEntities;

        public TeaRepository()
        {
            objTeaPickerDbEntities = new TeaPickerDbEntities();
        }

        public IEnumerable<SelectListItem> GetAllTeaType()
        {
            var objSelectListItems = new List<SelectListItem>();

            objSelectListItems = (from obj in objTeaPickerDbEntities.Teas
                                  select new SelectListItem()
                                  {
                                      Text = obj.TeaName,
                                      Value = obj.TeaId.ToString(),
                                      Selected = true
                                  }).ToList();

            return objSelectListItems;
        }
    }
}