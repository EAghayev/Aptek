using System.Web.Mvc;

namespace Aptek.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            //context.MapRoute(
            //    "Admin_default",
            //    "Admin/{controller}/{action}/{id}",
            //    new { action = "Index", id = UrlParameter.Optional }
            //);
            context.MapRoute(
               name: "admin",
               url: "admin/{controller}/{action}/{id}",
               defaults: new { controller = "Articles", action = "Index", Area = "admin", id = UrlParameter.Optional },
               namespaces: new[] { "Aptek.Areas.Admin.Controllers" }
           );
        }
    }
}