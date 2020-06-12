using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    [Table("Contatos")]
    public class Contato
    {
        [Key]
        public int ContatoID { get; set; }
        
        [MaxLength(60)]
        [Column(TypeName = "VARCHAR")]
        [Display(Name = "Nome do Contato")]
        [Required(ErrorMessage = "O nome do contato é obrigatório!")]
        public string NomeContato { get; set; }

        [MaxLength(14)]
        [Column(TypeName = "VARCHAR")]
        [Display(Name = "Telefone Fixo")]
        public string TelefoneFixoContato { get; set; }

        [MaxLength(14)]
        [Column(TypeName = "VARCHAR")]
        [Display(Name = "Celular")]
        public string CelularContato { get; set; }

        [MaxLength(30)]
        [Column(TypeName = "VARCHAR")]
        [Display(Name = "E-mail")]
        public string EmailContato { get; set; }

        public virtual ICollection<Endereco> ListaEnderecos { get; set; }
    }
}