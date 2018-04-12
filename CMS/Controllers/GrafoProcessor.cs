using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMS.Controllers
{
    public class GrafoProcessor : Controller
    {
        // GET: GrafoProcessor
        public ActionResult Index()
        {
            return View();
        }

        // GET: GrafoProcessor/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GrafoProcessor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GrafoProcessor/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: GrafoProcessor/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GrafoProcessor/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: GrafoProcessor/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GrafoProcessor/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
