using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Final
{
    internal class Program
    {
        
        static string[] equipos;
        static string[,] jugadoresNombres;
        static string[,] jugadoresApellidos;
        static int[,] edad;
        static int[,] goles;
        static int[,] asistencias;
        static int[,] partidos;
        static bool salida = true;
        static void Main(string[] args)
        {
            do
            {
                Arreglos();
                Menu();
                Console.ReadKey();
            } while (salida != false);
        }

        public static void Menu()
        {
            {
                Console.Clear();
                Console.WriteLine("Bienvenido al programa de estadisticas de jugadores de futbol.");
                Console.WriteLine();
                Console.WriteLine("1. Mostrar jugadores");
                Console.WriteLine("2. Agregar jugador.");
                Console.WriteLine("3. Mostrar estadisticas de jugadores");
                Console.WriteLine("4. Ordenar jugadores");
                Console.WriteLine("5. Salir");
                Console.WriteLine();
                Console.WriteLine("Seleccione una opcion.");
                char opc = Console.ReadKey().KeyChar;
                
                switch (opc)
                {
                    case '1':
                        Recorrido();
                        break;
                    case '2':
                        BuscarJugador();
                        break;
                    case '3':
                        Estadisticas();
                        break;
                    case '4':
                        Ordenamiento();
                        break;
                    case '5':
                        Console.Clear();
                        Console.WriteLine("Saliendo...");
                        salida = false;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida.");
                        return;
                }
            }
        }
        public static void Arreglos()
        {
            Console.Clear();
            equipos = new string[] { "Boca", "River", "Racing", "Independiente", "San Lorenzo" };
            jugadoresNombres = new string[,] {
                {"Edison","Miguel Angel","Milton","Kevin","Cristian" },
                { "Facundo", "Ignacio", "Pablo", "German", "Paulo" },
                { "Santiago", "Juan Fernando", "Agustin Ezequiel", "Roger", "Luciano Dario" },
                { "Ivan", "Federico", "Gabriel", "Santiago", "Kevin" },
                { "Sebastian", "Iker", "Nahuel", "Ezequiel", "Nahuel" } };
            jugadoresApellidos = new string[,] {
                { "Cavani", "Merentiel", "Gimenez", "Zenon", "Medina" },
                { "Colidio", "Fernandez", "Solari", "Pezzela", "Diaz" },
                { "Sosa", "Quintero", "Almendra", "Martinez", "Vietto" },
                { "Marcone", "Mancuello", "Avalos", "Montiel", "Lomonaco" },
                { "Blanco", "Muniain", "Barrios", "Cerutti", "Bustos" } };
            edad = new int[,] {
                {37,28,28,23,22},
                {24,34,23,33,30},
                {25,31,24,30,31},
                {34,35,33,24,22},
                {36,32,26,32,26} };
            goles = new int[,] {
                {399,83,79,12,9},
                {30,85,41,19,26},
                {4,68,10,89,102},
                {3,50,85,6,3},
                {96,81,10,31,22}};
            asistencias = new int[,] {
                {81,25,15,17,10},
                {25,98,28,10,10},
                {2,70,11,39,57},
                {4,60,22,7,1},
                {94,54,15,42,12}};
            partidos = new int[,] {
                {716,276,234,152,159},
                {176,535,168,397,351},
                {130,377,120,326,393},
                {515,464,306,75,59},
                {564,582,200,406,157}};
        }

        public static void Recorrido()
        {
            Console.Clear();
            for (int i = 0; i < equipos.Length; i++)
            {
                Console.WriteLine($"Equipo: {equipos[i]}");

                for (int j = 0; j < equipos.Length; j++)
                {
                    Console.WriteLine($"Jugador {j + 1}: {jugadoresNombres[i, j]} {jugadoresApellidos[i, j]}");
                }
                Console.WriteLine();
            }
            Continuar();
        }

        public static void BuscarJugador()
        {
            Console.Clear();
            Console.Write("Ingrese el nombre o apellido del jugador: ");
            string buscar = Console.ReadLine().ToLower();
            bool encontrado = false;

            for (int i = 0; i < equipos.Length; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    string nombreCompleto = $"{jugadoresNombres[i, j]} {jugadoresApellidos[i, j]}";

                    if (nombreCompleto.ToLower().Contains(buscar))
                    {
                        Console.WriteLine($"Equipo: {equipos[i]}");
                        Console.WriteLine($"Jugador encontrado: {nombreCompleto}");
                        encontrado = true;
                    }
                }

                Console.WriteLine(); 
            }

            if (!encontrado)
            {
                Console.WriteLine("No se encontró ningún jugador con ese nombre o apellido.");
            }
        }

        public static void AgregarJugador()
        {

        }
        public static void Ordenamiento()
        {
            Console.Clear ();
            Console.WriteLine("Ingrese como desea ordenar a los jugadores");
            Console.WriteLine("");
            Console.WriteLine("1. De mayor a menor.");
            Console.WriteLine("2. De menor a mayor.");
            int opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    MayorAMenor();
                    break;
                case 2:
                    MenorAMayor();
                    break;
                default:
                    break;
            }
        }
        public static void MenorAMayor()
        {
            Console.WriteLine("Ingrese como quiere ordenar a los jugadores");
            Console.WriteLine("");
            Console.WriteLine("1. Nombre.");
            Console.WriteLine("2. Apellido.");
            Console.WriteLine("3. Edad.");
            Console.WriteLine("4. Goles.");
            Console.WriteLine("5. Asistencias.");
            Console.WriteLine("6. Partidos.");
            string opc = Console.ReadLine().ToLower();

            for (int i = 0; i < opc.Length - 1; i++)
            {
                for (int j = 0; j < opc.Length - 1 - i; j++)
                {
                    if (opc[j] > opc[j + 1])
                    {

                    }
                }
            }
        }

        
        public static void Continuar()
        {
            Console.WriteLine("Presione una tecla para salir.");
            Console.ReadKey();
        }
        public static void MayorAMenor()
        {
        }
        public static void Estadisticas()
        {
            
            Console.Clear();
            for (int i = 0; i < equipos.Length; i++)
            {
                Console.WriteLine($"Equipo: {equipos[i]}");
                Console.WriteLine("");

                for (int j = 0; j < equipos.Length; j++)
                {
                    Console.WriteLine($"Jugador {j + 1}: {jugadoresNombres[i, j]} {jugadoresApellidos[i, j]}");
                    Console.WriteLine($"Edad: {edad[i, j]}");
                    Console.WriteLine($"Goles: {goles[i, j]}");
                    Console.WriteLine($"Asistencias: {asistencias[i, j]}");
                    Console.WriteLine($"Partidos: {partidos[i, j]}");
                    Console.WriteLine(""); 
                }

                Console.WriteLine(); 
            }
            
            Continuar(); 
        }
    }
}
