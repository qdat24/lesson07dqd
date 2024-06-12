using System.Web;
using System.Web.Mvc;

namespace dqdK22CNT3Lesson07db
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
