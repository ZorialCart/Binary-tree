using System;
using System.Security.Cryptography.X509Certificates;

namespace Binary_tree
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            string input;
            int opc = 0;
            Submenu menus = new Submenu();
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("   ╔════════════════════════╗ \n" +
                                  "   ║     MENÚ PRINCIPAL     ║ \n" +
                                  "   ╚════════════════════════╝ \n" +
                                "╔══════════════════════════════╗\n" +
                                "║                              ║\n" +
                                "║ ---------------------------- ║\n" +
                                "║       1.- Listas.            ║\n" +
                                "║       2.- Pilas.             ║\n" +
                                "║       3.- Colas.             ║\n" +
                                "║       4.- Árboles.           ║\n" +
                                "║       5.- Salir.             ║\n" +
                                "║ ____________________________ ║\n" +
                                "║                              ║\n" +
                                "╚══════════════════════════════╝\n");
                Console.Write("Seleccionar Opción → ");
                input = Console.ReadLine();
                if (String.IsNullOrEmpty(input) || int.TryParse(input, out opc))
                {

                    switch (opc)
                    {
                        case 1:
                            Console.Clear();
                            menus.listas();
                            Console.ReadLine();
                            break;
                        case 2:
                            Console.Clear();
                            menus.pilas();
                            Console.ReadLine();
                            break;
                        case 3:
                            Console.Clear();
                            menus.colas();
                            Console.ReadLine();
                            break;
                        case 4:
                            Console.Clear();
                            menus.arboles();
                            Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Saliendo del programa...");
                            continuar = false;
                            break;
                        default:
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                }
            }
            while (continuar);
        }
    }
}
