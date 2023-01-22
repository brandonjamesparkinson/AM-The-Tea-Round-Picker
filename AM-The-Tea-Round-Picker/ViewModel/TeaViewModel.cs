using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AM_The_Tea_Round_Picker.ViewModel
{
    public class TeaViewModel
    {
        public int TeaId { get; set; }

        [Display(Name = "Tea Name")]
        public string TeaName { get; set; }
    }
}