using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Final
{
    public class Liga
    {
        public List<Jugador> jugadores = new List<Jugador>();
        public List<Equipo> equipos = new List<Equipo>();
        
        public void CargarDatosIniciales()
        {
            // Agregar los jugadores iniciales
            AgregarJugador(new Jugador { Nombre = "Edison", Apellido = "Cavani", Edad = 37, Goles = 399, Asistencias = 81, Partidos = 716, Equipo = "Boca" });
            AgregarJugador(new Jugador { Nombre = "Miguel Angel", Apellido = "Merentiel", Edad = 28, Goles = 83, Asistencias = 25, Partidos = 276, Equipo = "Boca" });
            AgregarJugador(new Jugador { Nombre = "Milton", Apellido = "Gimenez", Edad = 28, Goles = 79, Asistencias = 15, Partidos = 234, Equipo = "Boca" });
            AgregarJugador(new Jugador { Nombre = "Kevin", Apellido = "Zenon", Edad = 23, Goles = 12, Asistencias = 17, Partidos = 152, Equipo = "Boca" });
            AgregarJugador(new Jugador { Nombre = "Cristian", Apellido = "Medina", Edad = 22, Goles = 9, Asistencias = 10, Partidos = 159, Equipo = "Boca" });

            AgregarJugador(new Jugador { Nombre = "Facundo", Apellido = "Colidio", Edad = 24, Goles = 30, Asistencias = 25, Partidos = 176, Equipo = "River" });
            AgregarJugador(new Jugador { Nombre = "Ignacio", Apellido = "Fernandez", Edad = 34, Goles = 85, Asistencias = 98, Partidos = 535, Equipo = "River" });
            AgregarJugador(new Jugador { Nombre = "Pablo", Apellido = "Solari", Edad = 23, Goles = 41, Asistencias = 28, Partidos = 168, Equipo = "River" });
            AgregarJugador(new Jugador { Nombre = "German", Apellido = "Pezzela", Edad = 33, Goles = 19, Asistencias = 10, Partidos = 397, Equipo = "River" });
            AgregarJugador(new Jugador { Nombre = "Paulo", Apellido = "Diaz", Edad = 30, Goles = 26, Asistencias = 10, Partidos = 351, Equipo = "River" });

            AgregarJugador(new Jugador { Nombre = "Santiago", Apellido = "Sosa", Edad = 25, Goles = 4, Asistencias = 2, Partidos = 130, Equipo = "Racing" });
            AgregarJugador(new Jugador { Nombre = "Juan Fernando", Apellido = "Quintero", Edad = 31, Goles = 68, Asistencias = 70, Partidos = 377, Equipo = "Racing" });
            AgregarJugador(new Jugador { Nombre = "Agustin Ezequiel", Apellido = "Almendra", Edad = 24, Goles = 10, Asistencias = 11, Partidos = 120, Equipo = "Racing" });
            AgregarJugador(new Jugador { Nombre = "Roger", Apellido = "Martinez", Edad = 30, Goles = 89, Asistencias = 39, Partidos = 326, Equipo = "Racing" });
            AgregarJugador(new Jugador { Nombre = "Luciano Dario", Apellido = "Vietto", Edad = 31, Goles = 102, Asistencias = 57, Partidos = 393, Equipo = "Racing" });

            AgregarJugador(new Jugador { Nombre = "Ivan", Apellido = "Marcone", Edad = 34, Goles = 3, Asistencias = 4, Partidos = 515, Equipo = "Independiente" });
            AgregarJugador(new Jugador { Nombre = "Federico", Apellido = "Mancuello", Edad = 35, Goles = 50, Asistencias = 60, Partidos = 464, Equipo = "Independiente" });
            AgregarJugador(new Jugador { Nombre = "Gabriel", Apellido = "Avalos", Edad = 33, Goles = 85, Asistencias = 22, Partidos = 306, Equipo = "Independiente" });
            AgregarJugador(new Jugador { Nombre = "Santiago", Apellido = "Montiel", Edad = 24, Goles = 6, Asistencias = 7, Partidos = 75, Equipo = "Independiente" });
            AgregarJugador(new Jugador { Nombre = "Kevin", Apellido = "Lomonaco", Edad = 22, Goles = 3, Asistencias = 1, Partidos = 59, Equipo = "Independiente" });

            AgregarJugador(new Jugador { Nombre = "Sebastian", Apellido = "Blanco", Edad = 36, Goles = 96, Asistencias = 94, Partidos = 564, Equipo = "San Lorenzo" });
            AgregarJugador(new Jugador { Nombre = "Iker", Apellido = "Muniain", Edad = 32, Goles = 81, Asistencias = 54, Partidos = 582, Equipo = "San Lorenzo" });
            AgregarJugador(new Jugador { Nombre = "Nahuel", Apellido = "Barrios", Edad = 26, Goles = 10, Asistencias = 15, Partidos = 200, Equipo = "San Lorenzo" });
            AgregarJugador(new Jugador { Nombre = "Ezequiel", Apellido = "Cerutti", Edad = 32, Goles = 31, Asistencias = 42, Partidos = 406, Equipo = "San Lorenzo" });
            AgregarJugador(new Jugador { Nombre = "Nahuel", Apellido = "Bustos", Edad = 26, Goles = 22, Asistencias = 12, Partidos = 157, Equipo = "San Lorenzo" });
        }

        public void AgregarJugador(Jugador jugador)
        {
            jugadores.Add(jugador);
            var equipo = equipos.FirstOrDefault(e => e.Nombre == jugador.Equipo);
            if (equipo == null)
            {
                equipo = new Equipo { Nombre = jugador.Equipo };
                equipos.Add(equipo);
            }
            equipo.Jugadores.Add(jugador);
        }

        public List<Equipo> ObtenerEquipos() => equipos;
        public List<Jugador> ObtenerJugadores() => jugadores;
    }
}
