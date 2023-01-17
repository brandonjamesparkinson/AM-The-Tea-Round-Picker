using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AM_The_Tea_Round_Picker.ViewModel
{
    public class TeaMakerViewModel
    {
        public int TeaMakerId { get; set; }
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public int TeaMakerCount { get; set; }
        public DateTime LastTeaMadeTime { get; set; }
    }
}