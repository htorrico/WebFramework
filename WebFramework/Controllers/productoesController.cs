using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebFramework.Models;

namespace WebFramework.Controllers
{
    public class productoesController : Controller
    {
        private NeptunoEntities db = new NeptunoEntities();

        //[HttpGet]
        public ActionResult IndexCategoria(int IdCategoria)
        {
            NeptunoEntities context = new NeptunoEntities();
            var productos = context.productos.Include(x=>x.categoria).Where(x => x.idCategoria == IdCategoria).ToList();
            return View(productos);

        }



        // GET: productoes
        public ActionResult Index()
        {
            var productos = db.productos.Include(p => p.categoria).Include(p => p.proveedore);
            return View(productos.ToList());
        }

        // GET: productoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            producto producto = db.productos.Find(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            return View(producto);
        }

        // GET: productoes/Create
        public ActionResult Create()
        {
            ViewBag.idCategoria = new SelectList(db.categorias, "idcategoria", "nombrecategoria");
            ViewBag.idProveedor = new SelectList(db.proveedores, "idProveedor", "nombreCompañia");
            return View();
        }

        // POST: productoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idproducto,nombreProducto,idProveedor,idCategoria,cantidadPorUnidad,precioUnidad,unidadesEnExistencia,unidadesEnPedido,nivelNuevoPedido,suspendido,categoriaProducto")] producto producto)
        {
            if (ModelState.IsValid)
            {
                db.productos.Add(producto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idCategoria = new SelectList(db.categorias, "idcategoria", "nombrecategoria", producto.idCategoria);
            ViewBag.idProveedor = new SelectList(db.proveedores, "idProveedor", "nombreCompañia", producto.idProveedor);
            return View(producto);
        }

        // GET: productoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            producto producto = db.productos.Find(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            ViewBag.idCategoria = new SelectList(db.categorias, "idcategoria", "nombrecategoria", producto.idCategoria);
            ViewBag.idProveedor = new SelectList(db.proveedores, "idProveedor", "nombreCompañia", producto.idProveedor);
            return View(producto);
        }

        // POST: productoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idproducto,nombreProducto,idProveedor,idCategoria,cantidadPorUnidad,precioUnidad,unidadesEnExistencia,unidadesEnPedido,nivelNuevoPedido,suspendido,categoriaProducto")] producto producto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(producto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idCategoria = new SelectList(db.categorias, "idcategoria", "nombrecategoria", producto.idCategoria);
            ViewBag.idProveedor = new SelectList(db.proveedores, "idProveedor", "nombreCompañia", producto.idProveedor);
            return View(producto);
        }

        // GET: productoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            producto producto = db.productos.Find(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            return View(producto);
        }

        // POST: productoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            producto producto = db.productos.Find(id);
            db.productos.Remove(producto);
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
