using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ToDoList.Models;

namespace ToDoList.Dao
{
    public class TarefaDao : DaoBase
    {
        public void Gravar(Tarefa objTarefa)
        {
            banco.Tarefas.Add(objTarefa);
            banco.SaveChanges();
        }
        public  void Alterar(Tarefa objTarefa)
        {
            var entry = banco.Entry(objTarefa);
            banco.Set<Tarefa>().Attach(objTarefa);
            entry.State = EntityState.Modified;
            banco.SaveChanges();
        }
        public Tarefa Buscar(int id)
        {
            return banco.Tarefas.FirstOrDefault(t => t.TarefaID == id);
        }
        public void Excluir(int id)
        {
            Tarefa objTarefa = Buscar(id);
            banco.Tarefas.Remove(objTarefa);
            banco.SaveChanges();
        }
        public IEnumerable<Tarefa> Buscar()
        {
            return banco.Tarefas.ToList();
        }
    }
}