using System;

namespace Binary_tree
{
    public class Arbol
    {
        public Nodo Raiz { get; set; }
        private Nodo Obs { get; set; }

        public bool Insert(int v)
        {
            Nodo nuevo, psave;
            bool Found;
            psave = Obs;
            Found = FindKey(v);
            if (Found)
            {
                Console.WriteLine("El nodo ya existe.");
                Obs = psave;
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
                    {
                        Obs.Izq = nuevo;
                    }
                    else
                    {
                        Obs.Der = nuevo;
                        Obs = nuevo;
                    }
                }
                return false;
            }
            return false ;
        }
        private bool FindKey(int v)
        {
            bool Found = false;
            Nodo q;
            q = Raiz;
            while (!Found && q != null)
            {
                if (v == q.Valor)
                {
                    Obs = q;
                    Found = true;
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
                            if (q.Der == null)
                                Obs = q;
                            q = q.Der;
                        }
                    }
                }
                return Found;
            }
            return false;
        }
    }
}

