using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TestFalabella.Models;

namespace TestFalabella.Controllers
{
    public class tbl_productosController : Controller
    {
        private PruebaFalabellaEntities db = new PruebaFalabellaEntities();

        // GET: tbl_productos
        public ActionResult Index()
        {
            return View(db.tbl_productos.ToList());
        }

        // GET: tbl_productos/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_productos tbl_productos = db.tbl_productos.Find(id);
            if (tbl_productos == null)
            {
                return HttpNotFound();
            }
            return View(tbl_productos);
        }

        // GET: tbl_productos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbl_productos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "pk_codigo_producto,nombre_producto,fk_tipo_producto,costo,status")] tbl_productos tbl_productos)
        {
            if (ModelState.IsValid)
            {
                db.tbl_productos.Add(tbl_productos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_productos);
        }

        // GET: tbl_productos/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_productos tbl_productos = db.tbl_productos.Find(id);
            if (tbl_productos == null)
            {
                return HttpNotFound();
            }
            return View(tbl_productos);
        }

        // POST: tbl_productos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "pk_codigo_producto,nombre_producto,fk_tipo_producto,costo,status")] tbl_productos tbl_productos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_productos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_productos);
        }

        // GET: tbl_productos/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_productos tbl_productos = db.tbl_productos.Find(id);
            if (tbl_productos == null)
            {
                return HttpNotFound();
            }
            return View(tbl_productos);
        }

        // POST: tbl_productos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            tbl_productos tbl_productos = db.tbl_productos.Find(id);
            db.tbl_productos.Remove(tbl_productos);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
