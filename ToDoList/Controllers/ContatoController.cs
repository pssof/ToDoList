using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoList.Dao;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class ContatoController : Controller
    {
        // GET: Contato
        public ActionResult Index()
        {
            var listaContatos = new ContatoDao().Listar();
            return View(listaContatos);
        }

        public ActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Novo(Contato objContato)
        {
            new ContatoDao().Gravar(objContato);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int id)
        {
            Contato objContato = new ContatoDao().Buscar(id);
            return View(objContato);
        }

        [HttpPost]
        public ActionResult Editar(Contato objContato)
        {
            new ContatoDao().Alterar(objContato);
            return RedirectToAction("Index");
        }

        public ActionResult Detalhar(int id)
        {
            Contato objContato = new ContatoDao().Buscar(id);
            return View(objContato);
        }

        public ActionResult Excluir(int id)
        {
            new ContatoDao().Excluir(id);
            return RedirectToAction("Index");
        }
    }
}