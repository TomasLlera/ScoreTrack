using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Final
{
    public class InterfazUsuario
    {
        private Liga liga = new Liga();
        public InterfazUsuario()
        {
            // Se crea la liga e inicializa los datos
            liga = new Liga();
            liga.CargarDatosIniciales();  // Cargar los jugadores al inicio
        }
        public void Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Agregar jugador");
                Console.WriteLine("2. Mostrar estadísticas");
                Console.WriteLine("3. Buscar jugador");
                Console.WriteLine("4. Ordenar jugadores");
                Console.WriteLine("5. Salir");
                char opc = Console.ReadKey().KeyChar;

                switch (opc)
                {
                    case '1': AgregarJugador(); break;
                    case '2': MostrarEstadisticas(); break;
                    case '3': BuscarJugador(); break;
                    case '4': OrdenarJugadores(); break;
                    case '5': return;
                    default: Console.WriteLine("Opción no válida."); break;
                }
            }
        }

        private void AgregarJugador()
        {
            Console.Clear();
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();
            Console.Write("Edad: ");
            int edad = int.Parse(Console.ReadLine());
            Console.Write("Goles: ");
            int goles = int.Parse(Console.ReadLine());
            Console.Write("Asistencias: ");
            int asistencias = int.Parse(Console.ReadLine());
            Console.Write("Partidos: ");
            int partidos = int.Parse(Console.ReadLine());
            Console.Write("Equipo: ");
            string equipo = Console.ReadLine();

            liga.AgregarJugador(new Jugador { Nombre = nombre, Apellido = apellido, Edad = edad, Goles = goles, Asistencias = asistencias, Partidos = partidos, Equipo = equipo });
            Console.WriteLine("Jugador agregado exitosamente.");
            Console.ReadKey();
        }

        private void MostrarEstadisticas()
        {
            Console.Clear();
            foreach (var equipo in liga.ObtenerEquipos())
                equipo.MostrarEstadisticas();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        private void BuscarJugador()
        {
            Console.Clear();
            Console.Write("Ingrese el nombre o apellido del jugador: ");
            string buscar = Console.ReadLine().ToLower();
            bool encontrado = false;

            foreach (var jugador in liga.ObtenerJugadores())
            {
                if (($"{jugador.Nombre} {jugador.Apellido}").ToLower().Contains(buscar))
                {
                    Console.WriteLine($"Jugador encontrado: {jugador.Nombre} {jugador.Apellido} - {jugador.Equipo}");
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("No se encontró ningún jugador con ese nombre o apellido.");
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        private void OrdenarJugadores()
        {
            Console.Clear();
            Console.WriteLine("¿Cómo desea ordenar a los jugadores?");
            Console.WriteLine("1. Ordenar por nombre");
            Console.WriteLine("2. Ordenar por goles");
            Console.WriteLine("3. Ordenar por edad");
            int opc = Console.ReadKey().KeyChar;

            switch (opc)
            {
                case 1: OrdenarPorNombre(); break;
                case 2: OrdenarPorGoles(); break;
                case 3: OrdenarPorEdad(); break;
                default: break;
            }
        }

        private void OrdenarPorNombre()
        {
            var jugadoresOrdenados = liga.ObtenerJugadores().OrderBy(j => j.Nombre).ToList();
            MostrarJugadoresOrdenados(jugadoresOrdenados);
        }

        private void OrdenarPorGoles()
        {
            var jugadoresOrdenados = liga.ObtenerJugadores().OrderByDescending(j => j.Goles).ToList();
            MostrarJugadoresOrdenados(jugadoresOrdenados);
        }

        private void OrdenarPorEdad()
        {
            var jugadoresOrdenados = liga.ObtenerJugadores().OrderBy(j => j.Edad).ToList();
            MostrarJugadoresOrdenados(jugadoresOrdenados);
        }

        private void MostrarJugadoresOrdenados(List<Jugador> jugadoresOrdenados)
        {
            Console.Clear();
            Console.WriteLine("Jugadores ordenados:");
            foreach (var jugador in jugadoresOrdenados)
            {
                Console.WriteLine($"{jugador.Nombre} {jugador.Apellido} - Goles: {jugador.Goles} - Edad: {jugador.Edad}");
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
