﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace Example1Snippet.Helpers
{
    public static class Helpers
    {
        public static HtmlString NavigationLink(this HtmlHelper html,
            string linkText,
            string actionName,
            string controllerName)
        {
            string contextAction = (string)html.ViewContext.RouteData.Values["action"];
            string contextController = (string)html.ViewContext.RouteData.Values["controller"];

            bool isCurrent =
                string.Equals(contextAction, actionName, StringComparison.CurrentCultureIgnoreCase) &&
                string.Equals(contextController, controllerName, StringComparison.CurrentCultureIgnoreCase);

            return html.ActionLink(
                linkText,
                actionName,
                controllerName,
                routeValues: null,
                htmlAttributes: isCurrent ? new { @class = "current" } : null);
        }
    }
}