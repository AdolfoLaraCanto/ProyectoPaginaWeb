using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventarioPaginaWeb.Models
{
    public partial class Motivo
    {
        [Display(Name = "ID Motivo")]
        public int IdMotivo { get; set; }

        [Display(Name = "Nombre Motivo")]
        public string NombreMotivo { get; set; }
    }
}
