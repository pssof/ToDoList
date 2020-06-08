using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class Tarefa
    {
        public int TarefaID { get; set; }

        public string NomeTarefa { get; set; }

        public DateTime DataInicioTarefa { get; set; }

        public DateTime DataFimTarefa { get; set; }

        public string DescricaoTarefa { get; set; }

        public string StatusTarefa { get; set; }
    }
}