using HttpRequests.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HttpRequests.Controllers
{
    public class RequestInformationController : Controller
    {
        // GET: RequestInformation
        public ActionResult Index()
        {
            RequestContext rq = new RequestContext();

            return View(rq.RequestInformation.ToList());
        }

        // GET: RequestInformation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RequestInformation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RequestInformation/Create
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

        // GET: RequestInformation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RequestInformation/Edit/5
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

        // GET: RequestInformation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RequestInformation/Delete/5
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
