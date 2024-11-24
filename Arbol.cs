using System;
using System.Runtime.Remoting.Messaging;

namespace Binary_tree
{
    public class Arbol
    {
        private int tamAct;

        public Nodo Raiz { get; set; }
        private Nodo Obs { get; set; }

        public Arbol()
        {
            this.tamAct = 0;
        }

        public bool Insert(double v)
        {
            Nodo nuevo, psave;
            bool found = false;
            psave = Obs;
            found = FindKey(v);
            if (found)
            {
                Console.WriteLine("El nodo ya existe.");
                Obs = psave;
                return false;
            }
            else
            {
                nuevo = new Nodo(v);
                if (Raiz == null)
                {
                    Raiz = nuevo;
                    Obs = nuevo;
                }
                else
                {
                    if (v < Obs.Valor)
                        Obs.Izq = nuevo;
                    else
                        Obs.Der = nuevo;
                    Obs = nuevo;
                }
                tamAct++;
            }
            return true;
        }

        private bool FindKey(double v)
        {
            bool found = false;
            Nodo q = Raiz;

            while (!found && q != null)
            {
                if (v == q.Valor)
                {
                    Obs = q;
                    found = true;
                }
                else
                {
                    if (v < q.Valor)
                    {
                        if (q.Izq == null)
                        {
                            Obs = q;
                            q = q.Izq;
                        }
                        else
                        {
                            q = q.Izq;
                        }
                    }
                    else
                    {
                        if (q.Der == null)
                        {
                            Obs = q;
                            q = q.Der;
                        }
                        else
                        {
                            q = q.Der;
                        }
                    }
                }
            }
            return found;
        }

        public int GetTam()
        {
            return tamAct;
        }
        private void PrintTree(Nodo nodo)
        {
            if(nodo != null)
            {
                Console.Write($"{nodo.Valor} ");
                PrintTree(nodo.Izq);
                Console.Write($"{nodo.Valor} ");
                PrintTree(nodo.Der);
                Console.Write($"{nodo.Valor} ");
            }
        }

        public void Print()
        {
            Console.WriteLine("Imprimiendo árbol:");
            PrintTree(Raiz);
        }

        public int Height(Nodo nodo)
        {
           
            if (nodo == null)
            {
                return -1;
            }
            int heightIzq= Height(nodo.Izq);
            int heightDer = Height(nodo.Der);

            
            return Math.Max(heightIzq, heightDer) + 1;
        }
        public void PrintHeight()
        {
            int altura = Height(Raiz);
            Console.WriteLine($"\nLa altura del árbol es: {altura}");
        }
    }
}

