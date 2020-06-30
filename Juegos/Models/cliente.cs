using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Juegos.Models
{
    public class cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public int Saldo { get; set; }
    }
}