using System.Web;
using System.Web.Mvc;

namespace AM_The_Tea_Round_Picker
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
