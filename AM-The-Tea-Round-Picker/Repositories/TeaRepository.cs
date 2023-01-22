using AM_The_Tea_Round_Picker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AM_The_Tea_Round_Picker.Repositories
{
    public class TeaRepository : ITeaRepository
    {
        //TODO : Refactor all mentions of tea into 'hot drinks' 
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

        public IEnumerable<Tea> GetAll()
        {
            return objTeaPickerDbEntities.Teas.ToList();
        }

        public Tea GetById(int teaId)
        {
            return objTeaPickerDbEntities.Teas.Find(teaId);
        }

        public void AddTea(Tea tea)
        {
            objTeaPickerDbEntities.Teas.Add(tea);
            objTeaPickerDbEntities.SaveChanges();
        }

        //todo: edit tea (name etc)
        //public void Update(Tea tea)
        //{

        //}

        public void Delete(int id)
        {
            var tea = objTeaPickerDbEntities.Teas.Find(id);
            objTeaPickerDbEntities.Teas.Remove(tea);
            objTeaPickerDbEntities.SaveChanges();
        }
    }
}