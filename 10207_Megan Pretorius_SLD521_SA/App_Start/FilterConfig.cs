using System.Web;
using System.Web.Mvc;

namespace _10207_Megan_Pretorius_SLD521_SA
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
