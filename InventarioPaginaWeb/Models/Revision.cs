using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventarioPaginaWeb.Models
{
    public partial class Revision
    {
        [Display(Name = "ID Revision")]
        public int IdRevision { get; set; }
        [Display(Name = "Numero de Reporte")]
        public int? NumReporte { get; set; }
        public string Descripcion { get; set; }
        public int? RMotivo { get; set; }
    }
}
