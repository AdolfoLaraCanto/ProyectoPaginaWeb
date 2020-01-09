using System;
using System.Collections.Generic;

namespace InventarioPaginaWeb.Models
{
    public partial class Inventario
    {
        public int IdInventario { get; set; }
        public DateTime Fecha { get; set; }
        public int RCliente { get; set; }
        public int RVerificador { get; set; }
        public int RRevision { get; set; }
        public int RTipoRegistro { get; set; }
        public string Status { get; set; }
    }
}
