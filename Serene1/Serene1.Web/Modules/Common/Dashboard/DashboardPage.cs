using Microsoft.AspNetCore.Mvc;
using Serenity;
using Serenity.Abstractions;
using Serenity.Data;
using Serenity.Web;
using System;

namespace Serene1.Common.Pages
{
    [Route("Dashboard/[action]")]
    public class DashboardController : Controller
    {
        [PageAuthorize, HttpGet, Route("~/")]
        public ActionResult Index(
            [FromServices] ITwoLevelCache cache,
            [FromServices] ISqlConnections sqlConnections
            )
        {
            if (cache is null)
                throw new ArgumentNullException(nameof(cache));

            if (sqlConnections is null)
                throw new ArgumentNullException(nameof(sqlConnections));

            var cachedModel = new DashboardPageModel() { };
            return View(MVC.Views.Common.Dashboard.DashboardIndex, cachedModel);
        }
    }
}
