using AM_The_Tea_Round_Picker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AM_The_Tea_Round_Picker.Repositories
{
    //TODO: teamaker stuff
    public class TeaMakerRepository
    {
        private TeaPickerDbEntities objTeaPickerDbEntities;

        public TeaMakerRepository()
        {
            objTeaPickerDbEntities = new TeaPickerDbEntities();
        }

        //public IEnumerable<SelectListItem> GetAllTeaMakers()
        //{
        //    var objSelectListItems = new List<SelectListItem>();

        //    //TODO: teamaker stuff
        //    objSelectListItems = (from obj in objTeaPickerDbEntities.TeaMakers
        //                          select new SelectListItem()
        //                          {
        //                              Text = obj.PersonName,
        //                              Value = obj.TeaMakerId.ToString(),
        //                              Selected = true
        //                          }).ToList();

        //    return objSelectListItems;
        //}
    }
}