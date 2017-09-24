using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace WebApplication9
{
    public class CustomActionnFilter : ActionFilterAttribute
    {

        public HttpRequest UsrAgnt
        {
            get
            {
                return HttpContext.Current.ApplicationInstance.Request;
            }
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

           string strUsrAgnt= UsrAgnt.UserAgent+ DateTime.Now.ToString();
            LogData(strUsrAgnt);

           
        }

        public void LogData(string data )
        {
            File.AppendAllText(HttpContext.Current.Server.MapPath("~/Data/Data.txt"), data);
        }



    }
}