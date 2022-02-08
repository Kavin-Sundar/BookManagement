using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BookManagementUsing3tierMVCwithJQuery
{
    public static class GlobalClass
    {
        public static string RenderRazorViewToString(System.Web.Mvc.Controller controller, string viewName, Object model = null)
        {
            controller.ViewData.Model = model;
            using (var sw = new StringWriter())
            {
                System.Web.Mvc.ViewEngineResult viewResult;
                viewResult = ViewEngines.Engines.FindPartialView(controller.ControllerContext, viewName);
                var viewContext = new ViewContext(controller.ControllerContext, viewResult.View, controller.ViewData, controller.TempData, sw);
                viewResult.View.Render(viewContext, sw);
                viewResult.ViewEngine.ReleaseView(controller.ControllerContext, viewResult.View);
                return sw.GetStringBuilder().ToString();
            }
        }
    }
}
