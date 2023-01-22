using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AM_The_Tea_Round_Picker.ViewModel
{
    public class PersonViewModel
    {
        public int PersonId { get; set; }

        [Display(Name = "Person Name")]
        public string PersomName { get; set; }
    }
}