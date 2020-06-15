using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoList.Dao;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class PublicidadeController : Controller
    {
        // GET: Publicidade
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Novo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Novo(Publicidade objPublicidade)
        {
            new PublicidadeDao().Gravar(objPublicidade);
            return RedirectToAction("Index");
        }
    }
}