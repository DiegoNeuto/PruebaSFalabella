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
    public class tbl_asesoresController : Controller
    {
        private PruebaFalabellaEntities db = new PruebaFalabellaEntities();

        // GET: tbl_asesores
        public ActionResult Index()
        {
            return View(db.tbl_asesores.ToList());
        }

        // GET: tbl_asesores/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_asesores tbl_asesores = db.tbl_asesores.Find(id);
            if (tbl_asesores == null)
            {
                return HttpNotFound();
            }
            return View(tbl_asesores);
        }

        // GET: tbl_asesores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbl_asesores/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "pk_id_asesor,nombre,clave,email")] tbl_asesores tbl_asesores)
        {
            if (ModelState.IsValid)
            {
                db.tbl_asesores.Add(tbl_asesores);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_asesores);
        }

        // GET: tbl_asesores/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_asesores tbl_asesores = db.tbl_asesores.Find(id);
            if (tbl_asesores == null)
            {
                return HttpNotFound();
            }
            return View(tbl_asesores);
        }

        // POST: tbl_asesores/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "pk_id_asesor,nombre,clave,email")] tbl_asesores tbl_asesores)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_asesores).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_asesores);
        }

        // GET: tbl_asesores/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_asesores tbl_asesores = db.tbl_asesores.Find(id);
            if (tbl_asesores == null)
            {
                return HttpNotFound();
            }
            return View(tbl_asesores);
        }

        // POST: tbl_asesores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            tbl_asesores tbl_asesores = db.tbl_asesores.Find(id);
            db.tbl_asesores.Remove(tbl_asesores);
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
