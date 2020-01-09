using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InventarioPaginaWeb.Models
{
    public class BigModel
    {
        public int  IdInventario { get; set; }

        public DateTime Fecha { get; set; }

        [Display(Name = "Nombre Encargado")]
        public string NombreEncargado { get; set; }

        [Display(Name = "Apellido Encargado")]
        public string ApellidoEncargado { get; set; }

        [Display(Name = "Nombre Verificador")]
        public string NombreVerificador { get; set; }

        [Display(Name = "Apellido Verificador")]
        public string ApellidoVerificador { get; set; }

        [Display(Name = "Numero de Reporte ")]
        public int NumeroReporte { get; set; }

        [Display(Name = "Descripcion Revision")]
        public string DescripcionRevision { get; set; }

        public string Motivo { get; set; }

        [Display(Name = "Tipo de Registro")]
        public string TipoRegistro { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        [Display(Name = "Numero de Serie")]
        public int NoSerie { get; set; }

        [Display(Name = "Descripcion Datos")]
        public string DescripcionDatos { get; set; }
        public string Observaciones { get; set; }

        [Display(Name = "Ubicacion Fisica")]
        public string UbicacionFisica { get; set; }

        [Display(Name = "Ubicacion Sistema")]
        public string UbicacionSistema { get; set; }
        public string Departamento { get; set; }
        public string Status { get; set; }
    }
}
