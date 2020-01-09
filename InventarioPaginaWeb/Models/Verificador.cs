using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventarioPaginaWeb.Models
{
    public partial class Verificador
    {
        [Display(Name = "ID Verificador")]
        public int IdVerificador { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
