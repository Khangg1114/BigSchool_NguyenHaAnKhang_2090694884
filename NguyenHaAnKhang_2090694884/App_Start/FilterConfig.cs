using System.Web;
using System.Web.Mvc;

namespace NguyenHaAnKhang_2090694884
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
