using System.Web;
using System.Web.Mvc;

namespace AUTHORIZE_FILTER
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
