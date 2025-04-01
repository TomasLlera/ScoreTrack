using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Final
{
    public class Equipo
    {
        public string Nombre { get; set; }
        public List<Jugador> Jugadores { get; set; } = new List<Jugador>();

        public void MostrarEstadisticas()
        {
            Console.WriteLine($"Estadísticas del Equipo {Nombre}");
            Console.WriteLine(new string('═', 80));
            Console.WriteLine("| Nombre            | Apellido         | Edad | Goles | Asistencias | Partidos |");
            Console.WriteLine(new string('═', 80));
            foreach (var jugador in Jugadores)
                Console.WriteLine(jugador.MostrarEstadisticas());
            Console.WriteLine(new string('═', 80));
        }
    }
}
