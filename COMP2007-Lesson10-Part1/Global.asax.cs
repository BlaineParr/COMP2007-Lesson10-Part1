using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI;


namespace COMP2007_Lesson10_Part1
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
                {
                    Path = "~/Scripts/jquery-2.1.4.min.js",
                    DebugPath = "~/Scripts/jquery-2.1.4.min.js",
                    CdnPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-2.1.4.min.js",
                    CdnDebugPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-2.1.4.min.js"
                });
        }
    }
}