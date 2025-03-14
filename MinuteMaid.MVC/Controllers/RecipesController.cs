﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinuteMaid.MVC.Data;
using System;

namespace MinuteMaid.MVC.Controllers
{
    public class RecipesController : Controller
    {
        private readonly MinuteMadeDbContext _context;

        public RecipesController(MinuteMadeDbContext context)
        {
            _context = context;
        }

        // GET: RecipesController
        public ActionResult Index()
        {
            return View(_context.Recipes.ToList());
        }

        // GET: RecipesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RecipesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RecipesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RecipesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RecipesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RecipesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RecipesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
