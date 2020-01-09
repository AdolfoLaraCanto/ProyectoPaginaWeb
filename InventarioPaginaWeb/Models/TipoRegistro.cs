using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventarioPaginaWeb.Models
{
    public partial class TipoRegistro
    {
        [Display(Name = "ID de Registro")]
        public int IdRegistro { get; set; }

        [Display(Name = "Tipo de Registro")]
        public string TipoRegistro1 { get; set; }
        public int? RDatos { get; set; }
    }
}
