﻿using HttpRequests.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HttpRequests.Controllers
{
    public class MovieHousesController : Controller
    {
        RequestContext rq = new RequestContext();
        // GET: MovieHouses
        public ActionResult Index()
        {
           
            return View(rq.MovieHouses.ToList());
        }

        // GET: MovieHouses/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MovieHouses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MovieHouses/Create
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

        // GET: MovieHouses/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MovieHouses/Edit/5
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

        // GET: MovieHouses/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MovieHouses/Delete/5
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
