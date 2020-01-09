using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventarioPaginaWeb.Models
{
    public partial class Datos
    {
        public int IdDatos { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        [Display(Name = "Numero de Serie ")]
        public int NoSerie { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }
        public int? RDependenciaEntidad { get; set; }
    }
}
