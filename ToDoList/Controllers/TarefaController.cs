using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoList.Dao;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class TarefaController : Controller
    {
        // GET: Tarefa
        public ActionResult Index()
        {
            var tarefas = new TarefaDao().Buscar();
            return View(tarefas);
        }
        //Efetuar correções ViewBag incorreta
        public ActionResult Novo()
        {
            ViewBag.Tarefas = new SelectList(new TarefaDao().Buscar().ToDictionary(t => t.TarefaID, t => t.NomeTarefa), "Key", "Value");
            return View();
        }
        //Efetuar correções ViewBag incorreta
        public ActionResult Editar(int id)
        {
            ViewBag.Tarefas = new SelectList(new TarefaDao().Buscar().ToDictionary(t => t.TarefaID, t => t.NomeTarefa), "Key", "Value");
            var tarefa = new TarefaDao().Buscar(id);
            return View(tarefa);
        }
        [HttpPost]
        public ActionResult Editar(Tarefa objTarefa)
        {
            new TarefaDao().Alterar(objTarefa);
            return RedirectToAction("Index", "Tarefa");
        }
        [HttpPost]
        public ActionResult Novo(Tarefa objTarefa)
        {
            new TarefaDao().Gravar(objTarefa);
            return RedirectToAction("Index", "Tarefa");
        }
        public ActionResult Detalhar(int id)
        {
            Tarefa tarefa = new TarefaDao().Buscar(id);
            return View(tarefa);
        }
        public ActionResult Excluir(int id)
        {
            new TarefaDao().Excluir(id);
            return RedirectToAction("Index", "Tarefa");
        }
    }
}