using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; //Base de datos
using System.Linq;
using System.Web;
using OperaWebSite.Validation;

namespace OperaWebSite.Models
{
    [Table("Opera")] //EF --> BD
    public class Opera
    {
        public int OperaId { get; set; }

        [Required(ErrorMessage ="Is required")]
        [StringLength(150)]
        public string Tittle { get; set; }

        [Required]
        public string Composer { get; set; }

        [CheckValidYear]
        public int Year { get; set; }
    }
}