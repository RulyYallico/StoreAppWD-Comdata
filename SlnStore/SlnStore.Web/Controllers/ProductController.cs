using SlnStore.Web.Models;
using SlnStore.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SlnStore.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService;

        public ProductController()
        {
            _productService = new ProductService();
        }

        // GET: Product
        public ActionResult Index()
        {
            return View(_productService.ObtenerAllProduct());
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Product collection)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    collection.ExpirationDate = DateTime.Now;
                    _productService.CreateProduct(collection);
                    return RedirectToAction("Index");
                }
            }
            catch(Exception ex)
            {
                //
            }
            return View();
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            var proId = _productService.ObtenerProductId(id);
            return View(proId);
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(Product collection)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    collection.ExpirationDate = DateTime.Now;
                    _productService.updateProduct(collection);
                    return RedirectToAction("Index");
                }
            }
            catch(Exception ex)
            {
                // 
            }
            return View(collection);
        }

        // GET: Alumno/Delete/5
        public ActionResult Delete(int id)
        {
            // TODO: Add delete logic here
            _productService.DeleteProduct(id);
            return RedirectToAction("Index");
        }

        //// POST: Alumno/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        //TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
