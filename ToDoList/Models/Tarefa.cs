using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Web;

namespace ToDoList.Models
{
    public class Tarefa
    {        
        [Key]
        public int TarefaID { get; set; }

        [MaxLength(20)]
        [Column(TypeName = "VARCHAR")]
        [Display(Name = "Nome da Tarefa")]
        [Required(ErrorMessage = "O nome da tarefa é obrigatório!")]
        public string NomeTarefa { get; set; }

        [Display(Name = "Data de Início")]
        [Required(ErrorMessage = "Data de início é obrigatória!")]
        public DateTime DataInicioTarefa { get; set; }
                
        [Display(Name = "Data de Término")]
        [Required(ErrorMessage = "Data de início é obrigatória!")]
        public DateTime DataFimTarefa { get; set; }

        [Display(Name = "Descrição da Tarefa")]
        [MaxLength(500)]
        [Column(TypeName = "VARCHAR")]
        public string DescricaoTarefa { get; set; }

        [Display(Name = "Status da Tarefa")]
        [Column(TypeName = "VARCHAR")]
        public string StatusTarefa { get; set; }
    }
}