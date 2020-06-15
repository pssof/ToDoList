using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToDoList.Models
{
    public class Publicidade
    {
        [Key]
        public int IdPublicidade { get; set; }

        public string Email { get; set; }
    }
}