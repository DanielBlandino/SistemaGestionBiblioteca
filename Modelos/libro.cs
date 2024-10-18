using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBiblioteca.Modelos
{
    internal class libro
    {
    }
}
namespace TuNombreDeProyecto.Modelos
{
    public class Libro
    {
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public int AñoPublicacion { get; set; }
        public string Genero { get; set; }
        public int NumeroCopias { get; set; }
    }
}
