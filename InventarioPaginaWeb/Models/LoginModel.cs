using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace InventarioPaginaWeb.Models
{
    public class LoginModel
    {
        [DisplayName("Correo electrónico")]
        public string Email { get; set; }

        [DisplayName("Contraseña")]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}