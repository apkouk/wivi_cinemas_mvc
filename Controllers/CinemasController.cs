using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cinevo_mvc.CinemasApi;
using cinevo_mvc.Models;


namespace wivi.Controllers
{
    public class CinemasController : Controller
    {
        public ActionResult Index()
        {
            try
            {
                return View(CinemasApi.GetAllCinemas());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public ActionResult Detail(string id)
        {
            try
            {
                return View(CinemasApi.GetCinemaById(id));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

    
        public ActionResult Create(Cinema cinema)
        {
            return View("Create");
        }


        public ActionResult Edit(string id)
        {
            try
            {
                return View(CinemasApi.GetCinemaById(id));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public ActionResult Delete(string id)
        {
            try
            {
                CinemasApi.DeleteCinema(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult CreateCinema(Cinema cinema)
        {
            try
            {
                CinemasApi.AddNewCinema(cinema);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return RedirectToAction("Index");
        }


        [HttpPost]
        public ActionResult UpdateCinema(Cinema cinema)
        {
            try
            {
                CinemasApi.UpdateCinema(cinema);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return RedirectToAction("Index");
        }
    }
}
