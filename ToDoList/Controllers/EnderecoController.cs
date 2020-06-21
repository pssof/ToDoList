using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoList.Dao;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class EnderecoController : Controller
    {
        // GET: Endereco
        public ActionResult Index()
        {
            var listaEnderecos = new EnderecoDao().Buscar();

            return View(listaEnderecos);
        }

        public ActionResult Novo()
        {
            ViewBag.Contatos = new SelectList(new ContatoDao().Buscar().ToDictionary(x => x.ContatoID, x => x.NomeContato), "Key", "Value");
            return View();
        }

        [HttpPost]
        public ActionResult Novo(Endereco objEndereco)
        {
            new EnderecoDao().Gravar(objEndereco);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int id)
        {
            ViewBag.Contatos = new SelectList(new ContatoDao().Buscar().ToDictionary(x => x.ContatoID, x => x.NomeContato), "Key", "Value");
            Endereco objEndereco = new EnderecoDao().Buscar(id);
            return View(objEndereco);
        }

        [HttpPost]
        public ActionResult Editar(Endereco objEndereco)
        {
            new EnderecoDao().Alterar(objEndereco);
            return RedirectToAction("Index");
        }

        public ActionResult Detalhar(int id)
        {
            Endereco objEndereco = new EnderecoDao().Buscar(id);
            ViewBag.Endereco = id;;
            return View(objEndereco);
        }

        public ActionResult Excluir(int id)
        {
            new EnderecoDao().Excluir(id);
            return RedirectToAction("Index");
        }
    }
}