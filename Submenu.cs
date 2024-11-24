﻿using System;

namespace Binary_tree
{
    public class Submenu
    {
        public  void listas()
        {
            bool menu = true;
            string input;
            int opc = 0;
            int pos = 0;
            int nodo = 0;
            int lastValor;
            int nuevo = 0;
            bool cambio;

            Listas myLista = new Listas();
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine( "   ╔════════════════════════╗ \n" +
                                   "   ║     MENÚ DE LISTAS     ║ \n" +
                                   "   ╚════════════════════════╝ \n" +
                                   "╔══════════════════════════════╗\n" +
                                   "║                              ║\n" +
                                   "║ ---------------------------- ║\n" +
                                   "║    1.- Insertar Nodo.        ║\n" +
                                   "║    2.- Imprimir Tamaño.      ║\n" +
                                   "║    3.- Buscar Nodo.          ║\n" +
                                   "║    4.- Borrar Nodo.          ║\n" +
                                   "║    5.- Modificar Nodo.       ║\n" +
                                   "║    6.- Buscar Valor.         ║\n" +
                                   "║    7.- Imprimir Lista.       ║\n" +
                                   "║    8.- Regresar.             ║\n" +
                                   "║ ____________________________ ║\n" +
                                   "║                              ║\n" +
                                   "╚══════════════════════════════╝\n");
                Console.Write("Seleccionar Opción → ");
                input = Console.ReadLine();

                if (int.TryParse(input, out opc) && opc >= 1 && opc <= 8)
                {
                    switch (opc)
                    {
                        case 1:
                            Console.Clear();
                            int valor = 0;
                            Console.WriteLine("   ╔════════════════════════╗ \n" +
                                              "   ║      INSERTAR NODO     ║ \n" +
                                              "   ╚════════════════════════╝ \n");
                            Console.Write("Ingrese el valor del nodo → ");
                            valor = Convert.ToInt32(Console.ReadLine());
                            myLista.Add(valor);
                            Console.WriteLine($"\nEl nodo se insertó correctamente.");
                            Console.ReadLine();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("   ╔════════════════════════╗ \n" +
                                              "   ║     IMPRIMIR TAMAÑO    ║ \n" +
                                              "   ╚════════════════════════╝ \n");
                            Console.WriteLine($"Cantidad de nodos existentes: {myLista.Count()}");
                            Console.ReadLine();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("   ╔═══════════════════════╗ \n" +
                                              "   ║      Buscar Nodo      ║ \n" +
                                              "   ╚═══════════════════════╝ \n");
                            Console.Write("Ingrese la posición del valor a encontrar → ");
                            pos = Convert.ToInt32(Console.ReadLine());

                            valor = myLista.Find(pos);
                            if (pos != -1)
                            {
                                Console.WriteLine($"\nLa posición: {pos}, tiene el valor: {valor}");
                            }
                            else
                            {
                                Console.WriteLine("\nError inesperado. Valor inválido o fuera de rango");
                            }
                            Console.ReadLine();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("   ╔════════════════════════╗ \n" +
                                              "   ║       BORRAR NODO      ║ \n" +
                                              "   ╚════════════════════════╝ \n");
                            Console.WriteLine("Ingrese el nodo a borrar → ");
                            nodo = Convert.ToInt32(Console.ReadLine());
                            lastValor = myLista.Find(nodo);
                            if (myLista.Delete(nodo))
                            {
                                Console.WriteLine($"\nEl nodo: {nodo} con el valor: {lastValor} fué eliminado.");
                            }
                            else
                            {
                                Console.WriteLine("\nError inesperado.");
                            }
                            Console.ReadLine();
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("   ╔═══════════════════════╗ \n" +
                                              "   ║     MODIFICAR NODO    ║ \n" +
                                              "   ╚═══════════════════════╝ \n");
                            Console.Write("Ingrese la posición del valor a cambiar → ");
                            pos = Convert.ToInt32(Console.ReadLine());
                            Console.Write("\nIngrese el nuevo valor → ");
                            nuevo = Convert.ToInt32(Console.ReadLine());

                            myLista.Change(pos, nuevo);

                            if (cambio = true)
                            {
                                Console.WriteLine($"\nLa posición: {pos}, tiene un nuevo valor: {nuevo}");
                            }
                            else
                            {
                                Console.WriteLine($"\nNo se puedo cambiar el valor de la posición: {pos}.");
                                Console.ReadKey();
                            }
                            break;
                        case 6:
                            Console.Clear();
                            Console.WriteLine("   ╔═══════════════════════╗ \n" +
                                              "   ║      BUSCAR NODO      ║ \n" +
                                              "   ╚═══════════════════════╝ \n");
                            Console.Write("Ingrese el valor de la posición a encontrar → ");
                            valor = Convert.ToInt32(Console.ReadLine());
                            pos = myLista.FindValue(valor);

                            if (pos != -1)
                            {
                                Console.WriteLine($"\nEl valor: {valor}, tiene la posición: {pos}");
                            }
                            else
                            {
                                Console.WriteLine("\nError inesperado. El valor no existe.");
                            }
                            Console.ReadLine();
                            break;
                        case 7:
                            Console.Clear();
                            Console.WriteLine("   ╔════════════════════════╗ \n" +
                                              "   ║      IMPRIMIR LISTA    ║ \n" +
                                              "   ╚════════════════════════╝ \n");
                            Console.WriteLine("La lista es: \n");
                            myLista.DrawScreen(myLista);
                            Console.ReadKey();
                            break;
                        case 8:
                            menu = false;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                }

                if (menu) Console.ReadKey();

            } while (menu);
        }


        public void pilas()
        {
            bool menu = true;
            string input;
            int opc = 0;
            bool state = true;
            int value;
            string entry;
            Pilas myPill = new Pilas(0);
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("   ╔═════════════════════════╗ \n" +
                                  "   ║      MENÚ DE PILAS      ║ \n" +
                                  "   ╚═════════════════════════╝ \n" +
                                "╔══════════════════════════════╗\n" +
                                "║                              ║\n" +
                                "║ ---------------------------- ║\n" +
                                "║    1.- Establecer Tamaño.    ║\n" +
                                "║    2.- Push.                 ║\n" +
                                "║    3.- Pop.                  ║\n" +
                                "║    4.- Imprimir.             ║\n" +
                                "║    5.- Regresar.             ║\n" +
                                "║ ____________________________ ║\n" +
                                "║                              ║\n" +
                                "╚══════════════════════════════╝\n");
                Console.Write("Seleccionar Opción → ");
                input = Console.ReadLine();
                if (int.TryParse(input, out opc) && opc >= 1 && opc <= 5)
                {
                    switch (opc)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("   ╔═════════════════════════════╗ \n" +
                                              "   ║      ESTABLECER TAMAÑO      ║ \n" +
                                              "   ╚═════════════════════════════╝ \n");
                            Console.Write("\nIngrese el tamaño de la pila → ");
                            entry = Console.ReadLine();

                            if (!String.IsNullOrEmpty(entry) &&

                            int.TryParse(entry, out value))
                            {
                                myPill = new Pilas(value);
                                Console.WriteLine("Valor insertado correctamente.");
                            }
                            else
                            {

                                Console.WriteLine("Entrada inválida. Ingrese un número válido.");
                            }
                            Console.Read();
                            break;
                        case 2:
                            Console.Clear();
                            int val;
                            bool res;
                            Console.WriteLine("   ╔════════════════╗ \n" +
                                              "   ║      PUSH      ║ \n" +
                                              "   ╚════════════════╝ \n");
                            Console.Write("\nIngrese el valor ainsertar → ");
                            entry = Console.ReadLine();
                            if (!String.IsNullOrEmpty(entry) &&
                            int.TryParse(entry, out val))
                            {
                                res = myPill.Push(val);

                                if (res)
                                {
                                    Console.WriteLine($"\nLa inserción: {val}, se generó con éxito.");
                                }

                                else
                                {
                                    Console.WriteLine($"\n¡PILA LLENA!... La inserción: {val}, NO se pudo generar.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Entrada inválida. Ingrese un número válido.");
                            }
                            Console.Read();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("   ╔════════════════╗ \n" +
                                              "   ║       POP      ║ \n" +
                                              "   ╚════════════════╝ \n");
                            if (!myPill.Empty())
                            {
                                double pop = myPill.Pop();
                                Console.WriteLine($"\nEl valor eliminado es: {pop}.");
                            }
                            else
                            {
                                Console.WriteLine("LA PILA ESTÁ VACÍA.");
                            }
                            Console.ReadLine();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("   ╔════════════════════╗ \n" +
                                              "   ║      IMPRIMIR      ║ \n" +
                                              "   ╚════════════════════╝ \n");
                            if (!myPill.Empty())
                            {
                                Console.WriteLine("\nLos valores dentro de la Pila son: ");
                                myPill.PrintStack();
                            }
                            else
                            {
                                Console.WriteLine("\n!LA PILA ESTÁ VACÍA!.");
                            }
                            Console.ReadKey();
                            Console.ReadLine();
                            break;
                        case 5:
                            menu = false;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                }

                if (menu) Console.ReadKey();

            } while (menu);
        }
        public void colas()
        {
            var myCola = new Colas(0);
            bool state = true;
            string input;
            string entry;
            int opc = 0;
            int value = 0;
            bool menu = true;

            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("   ╔═════════════════════════╗ \n" +
                                  "   ║      MENÚ DE COLAS      ║ \n" +
                                  "   ╚═════════════════════════╝ \n" +
                                "╔══════════════════════════════╗\n" +
                                "║                              ║\n" +
                                "║ ---------------------------- ║\n" +
                                "║    1.- Establecer Tamaño.    ║\n" +
                                "║    2.- Insert.               ║\n" +
                                "║    3.- Extract.              ║\n" +
                                "║    4.- Imprimir.             ║\n" +
                                "║    5.- Regresar.             ║\n" +
                                "║ ____________________________ ║\n" +
                                "║                              ║\n" +
                                "╚══════════════════════════════╝\n");
                Console.Write("Seleccionar Opción → ");
                input = Console.ReadLine();
                if (int.TryParse(input, out opc) && opc >= 1 && opc <= 5)
                {
                    switch (opc)
                    {
                        case 1:
                            Console.Clear();

                            Console.WriteLine(" ╔═══════════════════════╗ \n" +
                                              " ║   Establecer tamaño   ║ \n" +
                                              " ╚═══════════════════════╝ ");
                            Console.Write("\nIngrese el tamaño de la pila → ");
                            entry = Console.ReadLine();

                            if (!String.IsNullOrEmpty(entry) && int.TryParse(entry, out value))
                            {
                                myCola = new Colas(value);
                                Console.WriteLine($"\nEl tamaño de la cola es de: {value}.");
                            }
                            else
                            {
                                Console.WriteLine("Entrada inválida. Ingrese un número válido.");
                            }
                            Console.ReadKey();

                            break;
                        case 2:
                            Console.Clear();
                            double val;
                            bool res;

                            Console.WriteLine(" ╔════════════╗ \n" +
                                              " ║   Insert   ║ \n" +
                                              " ╚════════════╝ ");
                            Console.Write("\nIngrese el valor a insertar → ");
                            entry = Console.ReadLine();
                            if (!String.IsNullOrEmpty(entry) && double.TryParse(entry, out val)){
                                res = myCola.Insert(val);

                                if (res){
                                    Console.WriteLine($"\nLa inserción del valor: {val}, se generó con éxito.");
                                } else { 
                                    Console.WriteLine($"\n¡COLA LLENA!... La inserción: {val}, NO se pudo generar.");
                                }
                            }
                            else
                            {

                                Console.WriteLine("Entrada inválida. Ingrese un número válido.");
                            }
                            Console.ReadKey();

                            break;
                        case 3:
                            Console.Clear();

                            Console.WriteLine(" ╔═══════════════╗ \n" +
                                              " ║    Extract    ║ \n" +
                                              " ╚═══════════════╝");
                            double valor = myCola.Extract();

                            Console.WriteLine($"El valor extraído es: {valor}");
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.Clear();

                            Console.WriteLine(" ╔═══════════════════╗ \n" +
                                              " ║   IMPRIMIR PILA   ║ \n" +
                                              " ╚═══════════════════╝");
                            if (!myCola.UnderFlow()) {
                                Console.WriteLine("\nLos valores dentro de la Pila son: ");
                            }
                            
                            myCola.Print();
                            Console.ReadKey();
                            break;
                        case 5:
                            menu = false;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                }

                if (menu) Console.ReadKey();

            } while (menu);
        }


        public void arboles()
        {
            bool menu = true;
            string input;
            int opc = 0;
            bool res;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("   ╔════════════════════════╗ \n" +
                                  "   ║     MENÚ DE ARBOLES    ║ \n" +
                                  "   ╚════════════════════════╝ \n" +
                                "╔══════════════════════════════╗\n" +
                                "║                              ║\n" +
                                "║ ---------------------------- ║\n" +
                                "║    1.- Establecer Tamaño.    ║\n" +
                                "║    2.- Insert.               ║\n" +
                                "║    3.- Extract.              ║\n" +
                                "║    4.- Imprimir.             ║\n" +
                                "║    5.- Regresar.             ║\n" +
                                "║ ____________________________ ║\n" +
                                "║                              ║\n" +
                                "╚══════════════════════════════╝\n");
                Console.Write("Seleccionar Opción → ");
                input = Console.ReadLine();
                if (int.TryParse(input, out opc) && opc >= 1 && opc <= 5)
                {
                    switch (opc)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine(" ╔═══════════════════════╗ \n" +
                                              " ║   Establecer tamaño   ║ \n" +
                                              " ╚═══════════════════════╝ ");
                            Console.Write("\nIngrese el tamaño del árbol → ");
                         
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.Clear();
                            double val = 0;
                            Console.WriteLine(" ╔════════════╗ \n" +
                                              " ║   Insert   ║ \n" +
                                              " ╚════════════╝ ");
                            Console.Write("\nIngrese el valor a insertar → ");
                           
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine(" ╔═══════════════╗ \n" +
                                              " ║    Extract    ║ \n" +
                                              " ╚═══════════════╝");
                            Console.ReadLine();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine(" ╔════════════════════╗ \n" +
                                              " ║   IMPRIMIR ÁRBOL   ║ \n" +
                                              " ╚════════════════════╝");
                            Console.ReadLine();
                            break;
                        case 5:
                            menu = false;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                }

                if (menu) Console.ReadKey();

            } while (menu);
        }
    }
}