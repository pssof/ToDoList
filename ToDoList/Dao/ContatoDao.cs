using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ToDoList.Models;

namespace ToDoList.Dao
{
    public class ContatoDao : DaoBase
    {
        public void Gravar(Contato objContato)
        {
            banco.Contatos.Add(objContato);
            banco.SaveChanges();
        }
        
        public void Alterar(Contato objContato)
        {
            var entry = banco.Entry(objContato);
            banco.Set<Contato>().Attach(objContato);
            entry.State = EntityState.Modified;
            banco.SaveChanges();
        }

        public Contato Buscar(int id)
        {
            return banco.Contatos.FirstOrDefault(c => c.ContatoID == id);
        }

        public void Excluir(int id)
        {
            Contato obj = Buscar(id);
            banco.Contatos.Remove(obj);
            banco.SaveChanges();
        }

        public IEnumerable<Contato> Buscar()
        {
            return banco.Contatos.ToList();
        }
    }
}