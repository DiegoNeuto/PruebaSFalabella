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
    public class tbl_pedidosController : Controller
    {
        private PruebaFalabellaEntities db = new PruebaFalabellaEntities();

        // GET: tbl_pedidos
        public ActionResult Index()
        {
            return View(db.tbl_pedidos.ToList());
        }

        // GET: tbl_pedidos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_pedidos tbl_pedidos = db.tbl_pedidos.Find(id);
            if (tbl_pedidos == null)
            {
                return HttpNotFound();
            }
            return View(tbl_pedidos);
        }

        // GET: tbl_pedidos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbl_pedidos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "pk_id_pedido,fecha,codigo_empresa,total_costo,observaciones,codigo_asesor,status")] tbl_pedidos tbl_pedidos)
        {
            if (ModelState.IsValid)
            {
                db.tbl_pedidos.Add(tbl_pedidos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_pedidos);
        }

        // GET: tbl_pedidos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_pedidos tbl_pedidos = db.tbl_pedidos.Find(id);
            if (tbl_pedidos == null)
            {
                return HttpNotFound();
            }
            return View(tbl_pedidos);
        }

        // POST: tbl_pedidos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "pk_id_pedido,fecha,codigo_empresa,total_costo,observaciones,codigo_asesor,status")] tbl_pedidos tbl_pedidos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_pedidos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_pedidos);
        }

        // GET: tbl_pedidos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_pedidos tbl_pedidos = db.tbl_pedidos.Find(id);
            if (tbl_pedidos == null)
            {
                return HttpNotFound();
            }
            return View(tbl_pedidos);
        }

        // POST: tbl_pedidos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_pedidos tbl_pedidos = db.tbl_pedidos.Find(id);
            db.tbl_pedidos.Remove(tbl_pedidos);
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
