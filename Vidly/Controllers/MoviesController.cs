﻿using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movie/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            return View(movie);
        }

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }


        //        public ActionResult Edit(int id)
        //        {
        //            return Content("id=" + id);
        //        }
        //
        //        //movies
        //        public ActionResult Index(int? pageIndex, string sortBy)
        //        {
        //            if (!pageIndex.HasValue)
        //                pageIndex = 1;
        //            if (string.IsNullOrWhiteSpace(sortBy))
        //                sortBy = "Name";
        //            return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //        }
    }
}