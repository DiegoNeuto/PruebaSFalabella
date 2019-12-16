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
    public class tbl_empresasController : Controller
    {
        private PruebaFalabellaEntities db = new PruebaFalabellaEntities();

        // GET: tbl_empresas
        public ActionResult Index()
        {
            return View(db.tbl_empresas.ToList());
        }

        // GET: tbl_empresas/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_empresas tbl_empresas = db.tbl_empresas.Find(id);
            if (tbl_empresas == null)
            {
                return HttpNotFound();
            }
            return View(tbl_empresas);
        }

        // GET: tbl_empresas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbl_empresas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "pk_codigo_cliente,nombre_cliente,nit,direccion,contacto,telefono,fax,email,ciudad,status")] tbl_empresas tbl_empresas)
        {
            if (ModelState.IsValid)
            {
                db.tbl_empresas.Add(tbl_empresas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_empresas);
        }

        // GET: tbl_empresas/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_empresas tbl_empresas = db.tbl_empresas.Find(id);
            if (tbl_empresas == null)
            {
                return HttpNotFound();
            }
            return View(tbl_empresas);
        }

        // POST: tbl_empresas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "pk_codigo_cliente,nombre_cliente,nit,direccion,contacto,telefono,fax,email,ciudad,status")] tbl_empresas tbl_empresas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_empresas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_empresas);
        }

        // GET: tbl_empresas/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_empresas tbl_empresas = db.tbl_empresas.Find(id);
            if (tbl_empresas == null)
            {
                return HttpNotFound();
            }
            return View(tbl_empresas);
        }

        // POST: tbl_empresas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            tbl_empresas tbl_empresas = db.tbl_empresas.Find(id);
            db.tbl_empresas.Remove(tbl_empresas);
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
