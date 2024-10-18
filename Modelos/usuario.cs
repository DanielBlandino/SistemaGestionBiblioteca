using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBiblioteca.Modelos
{
    internal class usuario
    {
    }
}
namespace TuNombreDeProyecto.Modelos
{
    public class Usuario
    {
        public int IDUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
    }
}
