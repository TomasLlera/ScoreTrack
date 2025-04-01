using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Final
{
    public class Jugador
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public int Goles { get; set; }
        public int Asistencias { get; set; }
        public int Partidos { get; set; }
        public string Equipo { get; set; }

        public string MostrarEstadisticas()
        {
            return $"| {Nombre,-17} | {Apellido,-15} | {Edad,4} | {Goles,5} | {Asistencias,12} | {Partidos,8} |";
        }
    }
}
