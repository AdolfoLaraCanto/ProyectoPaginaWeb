using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventarioPaginaWeb.Models
{
    public partial class Encargado
    {
        [Display(Name = "Id Encargado")]
        public int IdEncargado { get; set; }

        [Display(Name = "Clave Encargado")]
        public string ClaveEncargado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
