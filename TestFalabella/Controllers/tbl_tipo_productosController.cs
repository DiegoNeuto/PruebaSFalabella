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
    public class tbl_tipo_productosController : Controller
    {
        private PruebaFalabellaEntities db = new PruebaFalabellaEntities();

        // GET: tbl_tipo_productos
        public ActionResult Index()
        {
            return View(db.tbl_tipo_productos.ToList());
        }

        // GET: tbl_tipo_productos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_tipo_productos tbl_tipo_productos = db.tbl_tipo_productos.Find(id);
            if (tbl_tipo_productos == null)
            {
                return HttpNotFound();
            }
            return View(tbl_tipo_productos);
        }

        // GET: tbl_tipo_productos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbl_tipo_productos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "pk_tipo_producto,nombre_tipo")] tbl_tipo_productos tbl_tipo_productos)
        {
            if (ModelState.IsValid)
            {
                db.tbl_tipo_productos.Add(tbl_tipo_productos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_tipo_productos);
        }

        // GET: tbl_tipo_productos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_tipo_productos tbl_tipo_productos = db.tbl_tipo_productos.Find(id);
            if (tbl_tipo_productos == null)
            {
                return HttpNotFound();
            }
            return View(tbl_tipo_productos);
        }

        // POST: tbl_tipo_productos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "pk_tipo_producto,nombre_tipo")] tbl_tipo_productos tbl_tipo_productos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_tipo_productos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_tipo_productos);
        }

        // GET: tbl_tipo_productos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_tipo_productos tbl_tipo_productos = db.tbl_tipo_productos.Find(id);
            if (tbl_tipo_productos == null)
            {
                return HttpNotFound();
            }
            return View(tbl_tipo_productos);
        }

        // POST: tbl_tipo_productos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_tipo_productos tbl_tipo_productos = db.tbl_tipo_productos.Find(id);
            db.tbl_tipo_productos.Remove(tbl_tipo_productos);
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
