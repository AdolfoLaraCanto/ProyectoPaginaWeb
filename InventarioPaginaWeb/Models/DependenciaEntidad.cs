using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventarioPaginaWeb.Models
{
    public partial class DependenciaEntidad
    {
        [Display(Name = "ID Dependencia/Entidad ")]
        public int IdDependenciaEntidad { get; set; }
        [Display(Name = "Ubicacion Sistema")]
        public string UbicacionSistema { get; set; }
        [Display(Name = "Ubicacion Fisica")]
        public string UbicacionFisica { get; set; }
        public string Departamento { get; set; }
    }
}
