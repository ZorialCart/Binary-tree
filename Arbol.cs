using System;
using System.Runtime.Remoting.Messaging;

namespace Binary_tree
{
    public class Arbol
    {
        private int tam;
        private int tamAct;

        public Nodo Raiz { get; set; }
        private Nodo Obs { get; set; }

        public Arbol(int tamMax)
        {
            this.tam = tamMax;
            this.tamAct = 0;
        }

        public bool Insert(double v)
        {
            if (this.tamAct >= tam) {
                Console.WriteLine("\n¡ÁRBOL LLENO!... No se puede insertar más nodos.");
                return false;
            }
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

        private void PrintTree(Nodo nodo)
        {
            if(nodo != null)
            {
                PrintTree(nodo.Izq);
                Console.WriteLine(nodo.Valor);
                PrintTree(nodo.Der);
            }
        }

        public void Print()
        {
            Console.WriteLine("Imprimiendo árbol:");
            PrintTree(Raiz);
        }
    }
}

