using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBiblioteca.Modelos
{
    internal class reserva
    {
    }
}
namespace TuNombreDeProyecto.Modelos
{
    public class Reserva
    {
        public int IDReserva { get; set; }
        public int IDUsuario { get; set; }
        public string ISBN { get; set; }
        public DateTime FechaReserva { get; set; }
        public DateTime FechaRetorno { get; set; }
    }
}
