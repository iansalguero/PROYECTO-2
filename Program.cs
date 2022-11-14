using System;

namespace Proyecto2_Album
{
    class Program
    {
        static Album album;

        static void Main(string[] args)
        {
            album = new Album();

            Console.WriteLine("Bienvenido al Mundial 2022!!");
            Console.WriteLine("Presione enter para continuar.");

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Iniciando...");
            Thread.Sleep(TimeSpan.FromSeconds(3));
            Console.Clear();

            bool control = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("1. Mostrar Todas las Estampas.");
                Console.WriteLine("2. Cambiar estado de una carta.");
                Console.WriteLine("3. Filtrar las estampas.");
                Console.WriteLine("4. Salir.");

                int opcion = Convert.ToInt16(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        album.Mostrar();
                        Console.WriteLine("");
                        Console.WriteLine("Presione cualquier tecla para continuar.");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Console.Write("Digite el codigo de la carta que desea cambiar: ");
                        Console.WriteLine("");
                        string UnCodigo = Console.ReadLine();
                        Console.WriteLine("¿A que estado? 0-Faltantes, 1-Encontradas, 2-Repetidas");
                        int UnEstado = Convert.ToInt16(Console.ReadLine());

                        album.cambiar_estado(UnCodigo, UnEstado);

                        Console.WriteLine("--------------------");
                        Console.WriteLine("Cambiando...");
                        Thread.Sleep(TimeSpan.FromSeconds(3));
                        Console.Clear();

                        Console.WriteLine("Cambiado con exito, puede continuar.");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("¿Desea ingresar una Categoria? S/N");
                        string respuesta = Console.ReadLine();

                        if (respuesta == "S")
                        {
                            Console.WriteLine("Ingrese la categoria: ");
                            string UnCategoria = Console.ReadLine();

                            Console.WriteLine("¿Que estados desea ver? 0-Faltantes, 1-Encontradas, 2-Repetidas");
                            int unEstado = Convert.ToInt16(Console.ReadLine());

                            Console.Clear();
                            album.Mostrar_Categoria(UnCategoria, unEstado);

                            Console.WriteLine("");
                            Console.WriteLine("Presione cualquier tecla para continuar.");

                        }
                        else
                        {
                            Console.WriteLine("¿Que estados desea ver? 0-Faltantes, 1-Encontradas, 2-Repetidas");
                            int dosEstado = Convert.ToInt16(Console.ReadLine());
                            Console.Clear();
                            album.Mostrar_Estado(dosEstado);
                            
                            Console.WriteLine("");
                            Console.WriteLine("Presione cualquier tecla para continuar.");

                        }
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Gracias por usar el programa.");
                        Console.WriteLine("Disfrute el Mundial.");
                        control = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("Por favor Presione cualquier tecla y luego, escoja una opcion.");
                        Console.ReadKey();
                        break;

                }
            } while (control == true);
        }
    }
}
