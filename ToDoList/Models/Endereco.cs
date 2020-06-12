using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class Endereco
    {
        public int EnderecoID { get; set; }

        [Display(Name = "Nome do Contato")]
        public int ContatoID { get; set; }

        [MaxLength(9)]
        [Column(TypeName = "VARCHAR")]
        [Display(Name = "CEP")]
        [Required(ErrorMessage = "O CEP é obrigatório!")]
        public string CepEndereco { get; set; }

        [MaxLength(40)]
        [Column(TypeName = "VARCHAR")]
        [Display(Name = "Rua")]
        [Required(ErrorMessage = "O nome da rua é obrigatório!")]
        public string NomeRua { get; set; }

        [MaxLength(8)]
        [Column(TypeName = "VARCHAR")]
        [Display(Name = "Número")]
        public string NumeroEndereco { get; set; }

        [MaxLength(40)]
        [Column(TypeName = "VARCHAR")]
        [Display(Name = "Bairro")]
        [Required(ErrorMessage = "O nome do bairro é obrigatório!")]
        public string NomeBairro { get; set; }

        [MaxLength(9)]
        [Column(TypeName = "VARCHAR")]
        [Display(Name = "Cidade")]
        [Required(ErrorMessage = "O nome da cidade é obrigatório!")]
        public string NomeCidade { get; set; }

        [MaxLength(2)]
        [Column(TypeName = "VARCHAR")]
        [Display(Name = "UF")]
        [Required(ErrorMessage = "A unidade federativa é obrigatório!")]
        public string UfEstado { get; set; }

        [MaxLength(20)]
        [Column(TypeName = "VARCHAR")]
        [Display(Name = "Complemento")]
        public string ComplementoEndereco { get; set; }

        public virtual Contato objContato { get; set; }
    }
}