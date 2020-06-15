using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ToDoList.Models;

namespace ToDoList.Dao
{
    public class EnderecoDao :DaoBase
    {
        public void Gravar(Endereco objEndereco)
        {
            banco.Enderecos.Add(objEndereco);
            banco.SaveChanges();
        }

        public void Alterar(Endereco objEndereco)
        {
            var entry = banco.Entry(objEndereco);
            banco.Set<Endereco>().Attach(objEndereco);
            entry.State = EntityState.Modified;
            banco.SaveChanges();
        }

        public Endereco Buscar(int id)
        {
            return banco.Enderecos.FirstOrDefault(e => e.EnderecoID == id);
        }

        public void Excluir(int id)
        {
            Endereco objEndereco = Buscar(id);
            banco.Enderecos.Remove(objEndereco);
            banco.SaveChanges();
        }

        public IEnumerable<Endereco> Buscar()
        {
            return banco.Enderecos.ToList();
        }

    }
}