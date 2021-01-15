﻿using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace Serene1.MovieDB.Pages
{

    [PageAuthorize(typeof(Entities.PersonRow))]
    public class PersonController : Controller
    {
        [Route("MovieDB/Person")]
        public ActionResult Index()
        {
            return View("~/Modules/MovieDB/Person/PersonIndex.cshtml");
        }
    }
}