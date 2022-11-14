using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;

namespace Proyecto2_Album
{
    class Program
    {
        static Album album;

        static void Main(string[] args)
        {
            album = new Album();

            Console.WriteLine("Bienvenido al Mundial 2022.");
            Console.Write("Presione cualquier tecla para continuar.");
            Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("--------------------");
            Console.Write("Iniciando...");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.Clear();

            bool control = true;
            do
            {
                int opcion;
                Console.WriteLine("        Menu.");
                Console.WriteLine("--------------------");
                Console.WriteLine("Seleccione una opcion:");
                Console.WriteLine("1. Mostrar todas las estampas.");
                Console.WriteLine("2. Cambiar estado de una estampa.");
                Console.WriteLine("3. Filtrar estampas.");
                Console.WriteLine("4. Filtrar estampas por rango.");
                Console.WriteLine("5. Salir.");

                do
                {
                    opcion = Convert.ToInt16(Console.ReadLine());
                    if (opcion < 1 || 5 < opcion)
                    {
                        Console.WriteLine("--------------------");
                        Console.Write("Elija una opcion valida: ");
                    }
                } while (opcion < 1 || 5 < opcion);
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("        ALBUM QATAR 2022");
                        Console.WriteLine("--------------------------------");

                        Console.Write("Cargando...");
                        Thread.Sleep(TimeSpan.FromSeconds(2));

                        Console.Clear();
                        Console.WriteLine("        ALBUM QATAR 2022");
                        Console.WriteLine("--------------------------------");
                        album.Mostrar();

                        Console.WriteLine("");
                        Console.WriteLine("--------------------");
                        Console.Write("Presione cualquier tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        Console.WriteLine("        ALBUM QATAR 2022");
                        Console.WriteLine("--------------------------------");
                        Console.Write("Digite el codigo de la estampa que desea cambiar: ");
                        string UnCodigo;
                        do
                        {
                            UnCodigo = Console.ReadLine();
                            if (UnCodigo == "")
                            {
                                Console.WriteLine("--------------------");
                                Console.Write("Indique un dato valido: ");
                            }
                        } while (UnCodigo == "");

                        Console.Clear();
                        Console.WriteLine("        ALBUM QATAR 2022");
                        Console.WriteLine("--------------------------------");
                        Console.Write("¿A que estado? (0 = Faltante, 1 = Encontrada, 2 = Repetida): ");
                        int UnEstado;
                        do
                        {
                            UnEstado = Convert.ToInt16(Console.ReadLine());
                            if (UnEstado < 0 || 2 < UnEstado)
                            {
                                Console.WriteLine("--------------------");
                                Console.Write("Ingrese una opcion valida: ");
                            }
                        } while (UnEstado < 0 || 2 < UnEstado);

                        album.cambiar_estado(UnCodigo, UnEstado);

                        Console.Clear();
                        Console.WriteLine("        ALBUM QATAR 2022");
                        Console.WriteLine("--------------------------------");
                        Console.Write("Cambiando...");
                        Thread.Sleep(TimeSpan.FromSeconds(2));
                        Console.Clear();

                        Console.Clear();
                        Console.WriteLine("        ALBUM QATAR 2022");
                        Console.WriteLine("--------------------------------");
                        Console.Write("Cambio exitoso, presione cualquier tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        Console.WriteLine("        ALBUM QATAR 2022");
                        Console.WriteLine("--------------------------------");
                        string respuesta;

                            Console.Write("¿Desea ingresar una Categoria? S/N: ");
                        do
                        {
                            respuesta = Console.ReadLine();
                            if (respuesta != "S" && respuesta != "N")
                            {
                                Console.WriteLine("--------------------");
                                Console.Write("Elija una opcion valida: ");
                            }
                        } while (respuesta != "S" && respuesta != "N");

                        Console.Clear();
                        Console.WriteLine("        ALBUM QATAR 2022");
                        Console.WriteLine("--------------------------------");

                        if (respuesta == "S")
                        {

                            Console.Write("Ingrese una categoria: ");
                            string UnCategoria;
                            do
                            {
                                UnCategoria = Console.ReadLine();
                                if (UnCategoria == "")
                                {
                                    Console.WriteLine("--------------------");
                                    Console.Write("Indique un dato valido: ");
                                }
                            } while (UnCategoria == "");

                            Console.Clear();
                            Console.WriteLine("        ALBUM QATAR 2022");
                            Console.WriteLine("--------------------------------");

                            Console.Write("¿Que estados desea ver? (0 = Faltantes, 1 = Encontradas, 2 = Repetidas): ");
                            int unEstado = 0;
                            do
                            {
                                unEstado = Convert.ToInt16(Console.ReadLine());
                                if (unEstado < 0 || 2 < unEstado)
                                {
                                    Console.WriteLine("--------------------");
                                    Console.Write("Ingrese una opcion valida: ");
                                }
                            } while (unEstado < 0 || 2 < unEstado);
                            Console.WriteLine("");

                            Console.Clear();
                            Console.WriteLine("        ALBUM QATAR 2022");
                            Console.WriteLine("--------------------------------");
                            Console.Write("Procesando...");
                            Thread.Sleep(TimeSpan.FromSeconds(2));

                            Console.Clear();
                            Console.WriteLine("        ALBUM QATAR 2022");
                            Console.WriteLine("--------------------------------");
                            album.Mostrar_Categoria(UnCategoria, unEstado);
                        }
                        else
                        {
                            Console.Write("¿Que estados desea ver ? (0 = Faltantes, 1 = Encontradas, 2 = Repetidas) : ");
                            int dosEstado;
                            do
                            {
                                dosEstado = Convert.ToInt16(Console.ReadLine());
                                if (dosEstado < 0 || 2 < dosEstado)
                                {
                                    Console.WriteLine("--------------------");
                                    Console.Write("Ingrese una opcion valida: ");
                                }
                            } while (dosEstado < 0 || 2 < dosEstado);

                            Console.Clear();
                            Console.WriteLine("        ALBUM QATAR 2022");
                            Console.WriteLine("--------------------------------");
                            Console.Write("Procesando...");
                            Thread.Sleep(TimeSpan.FromSeconds(2));

                            Console.Clear();
                            Console.WriteLine("        ALBUM QATAR 2022");
                            Console.WriteLine("--------------------------------");
                            album.Mostrar_Estado(dosEstado);

                        }

                        Console.WriteLine("");
                        Console.WriteLine("--------------------");
                        Console.Write("Presione cualquier tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case 4:
                        Console.WriteLine("        ALBUM QATAR 2022");
                        Console.WriteLine("--------------------------------");

                        Console.Write("Indique donde inicia el rango: ");
                        string inicioCodigo;
                        do
                        {
                            inicioCodigo = Console.ReadLine();
                            if (inicioCodigo == "")
                            {
                                Console.WriteLine("--------------------");
                                Console.Write("Ingrese una opcion valida: ");
                            }
                        } while (inicioCodigo == "");

                        Console.Clear();
                        Console.WriteLine("        ALBUM QATAR 2022");
                        Console.WriteLine("--------------------------------");

                        Console.Write("Indique donde finaliza el rango: ");
                        string finCodigo;
                        do
                        {
                            finCodigo = Console.ReadLine();
                            if (finCodigo == "")
                            {
                                Console.WriteLine("--------------------");
                                Console.Write("Ingrese una opcion valida: ");
                            }
                        } while (finCodigo == "");

                        Console.Clear();
                        Console.WriteLine("        ALBUM QATAR 2022");
                        Console.WriteLine("--------------------------------");

                        Console.Write("¿Que estados desea ver ? (0 = Faltantes, 1 = Encontradas, 2 = Repetidas) : ");
                        int tresEstado;
                        do
                        {
                            tresEstado = Convert.ToInt16(Console.ReadLine());
                            if (tresEstado < 0 || 2 < tresEstado)
                            {
                                Console.WriteLine("--------------------");
                                Console.Write("Ingrese una opcion valida: ");
                            }
                        } while (tresEstado < 0 || 2 < tresEstado);

                        Console.Clear();
                        Console.WriteLine("        ALBUM QATAR 2022");
                        Console.WriteLine("--------------------------------");

                        album.Mostrar_Rango(inicioCodigo,finCodigo, tresEstado);

                        Console.WriteLine("");
                        Console.WriteLine("--------------------");
                        Console.Write("Presione cualquier tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 5:
                        Console.WriteLine("Gracias por usar el programa.");
                        Console.WriteLine("Disfrute el Mundial.");
                        control = false;
                        break;
                }
            } while (control == true);
        }
    }
}
