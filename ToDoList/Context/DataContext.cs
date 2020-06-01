using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ToDoList.Context
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DataContext")
        {

        }
    }
}