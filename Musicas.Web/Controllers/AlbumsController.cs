using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Musicas.AcessoDados.Entity.Context;
using Musicas.Dominio;
using Musicas.Web.ViewModels.Album;
using Repositorios.Entity;
using RepositoriosComum;

namespace Musicas.Web.Controllers
{
    public class AlbumsController : Controller
    {
        private IRepositorioGenerico<Album, int> repositorioAlbum = new AlbumsRepositorio(new MusicasDbContext());
        //Albumsrepositorio herda repositoriosComumEntity, que por sua vez, IMPLEMENTA IRepositorioGenerico

        // GET: Albums
        public ActionResult Index()
        {
            //return View(db.Albums.ToList()); 
            //Este é o método padrão criado pelo Scafolding, porém ao criar a ViewModel,
            //a view esperada vem da Classe AlbumIndexViewModel
            return View(Mapper.Map<List<Album>, List<AlbumIndexViewModel>>(repositorioAlbum.Selecionar()));
        }

        // GET: Albums/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Album album = repositorioAlbum.SelecionarPorId(id.Value);
            if (album == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<Album, AlbumIndexViewModel>(album));
        }

        // GET: Albums/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Albums/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Ano,Observacoes,Email")] AlbumViewModel viewModel)
        {
            if (ModelState.IsValid)
            {

                Album album = Mapper.Map<AlbumViewModel, Album>(viewModel);
                repositorioAlbum.Inserir(album);
                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

        // GET: Albums/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Album album = repositorioAlbum.SelecionarPorId(id.Value);
            if (album == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<Album, AlbumViewModel>(album));
        }

        // POST: Albums/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Ano,Observacoes,Email")] AlbumViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Album album = Mapper.Map<AlbumViewModel, Album>(viewModel);
                repositorioAlbum.Alterar(album);
                return RedirectToAction("Index");
            }
            return View(viewModel);
        }

        // GET: Albums/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Album album = repositorioAlbum.SelecionarPorId(id.Value);
            if (album == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<Album, AlbumIndexViewModel>(album));
            
        }

        // POST: Albums/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            repositorioAlbum.ExcluirPorId(id);
            return RedirectToAction("Index");
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
