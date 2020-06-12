using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ToDoList.Models;

namespace ToDoList.Context
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DataContext")
        {

        }
        public virtual DbSet<Tarefa> Tarefas { get; set; }
        public virtual DbSet<Contato> Contatos { get; set; }
        public virtual DbSet<Endereco> Enderecos { get; set; }
    }
}