using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoList.Context;

namespace ToDoList.Dao
{
    public class DaoBase
    {
        protected readonly DataContext banco;

        public DaoBase()
        {
            banco = new DataContext();
        }

        public void Dispose()
        {
            banco.Dispose();
        }
    }
}