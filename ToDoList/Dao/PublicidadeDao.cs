using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoList.Models;

namespace ToDoList.Dao
{
    public class PublicidadeDao : DaoBase
    {
        public void Gravar(Publicidade objPublicidade)
        {
            banco.Publicidades.Add(objPublicidade);
            banco.SaveChanges();
        }
    }
}