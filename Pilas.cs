using System;

namespace Binary_tree
{
    public class Pilas
    {
        private int max;
        private int tope = 0;
        private NodoNormy inicio;
        private double valor;
        public int Max { get => max; set => max = value; }
        public int Tope { get => tope; set => tope = value; }
        public NodoNormy Inicio
        {
            get => inicio; set => inicio = value;
        }
        public double Valor
        {
            get => valor; set => valor = value;
        }
        public Pilas(int max)
        {
            Max = max;
            inicio = null;
            
        }
        public bool Empty()
        {
            if (Inicio == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Full()
        {
            if (Tope == Max)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void PrintStack()
        {
            //Imprime la Pila.
            if (Empty())
            {
                Console.WriteLine("\nLA PILA ESTÁ VACÍA...");
            }
            
            double[] val = new double[tope];
            NodoNormy actual = inicio;
            for (int i = 0; i < tope; i++)
            {
                val[i] = actual.Valor;
                actual = actual.Sig;
            }
            for (int i = tope - 1; i >= 0; i--)
            {
                Console.WriteLine(val[i]);
            }
        }
        public bool Push(int num)
        {
            //Regresa true si la inserción es exitosa o false si la pila esta llena y no se inserto
            NodoNormy nuevo = new NodoNormy(num);
            if (this.Full())
            {
                return false;
            }
            if (Inicio == null)
            {
                Inicio = nuevo;
                Tope++;
                return true;
            }
            NodoNormy actual = inicio;

            while (actual.Sig != null)
            {
                actual = actual.Sig;
            }
            actual.Sig = nuevo;
            Tope++;
            return true;
        }
        public double Pop()
        {
            //Regresa el numero sacado de la pila, si la pila esta vacía regresa -1
            double value = 0;
            if (this.Empty())
            {
                return -1;
            }
            NodoNormy act = inicio;
            int tope1 = tope - 1;
            if (this.tope == 1)
            {
                value = inicio.Valor;
                inicio = inicio.Sig;
                Tope--;
                return value;
            }
            for (int i = 0; i <= tope1; i++)
            {
                if (act == null)
                {
                    return -1;
                }
                else
                {
                    if (i == tope1 - 1)
                    {
                        if (act.Sig == null)
                        {
                            return -1;

                        }
                        value = act.Sig.Valor;
                        act.Sig = act.Sig.Sig;
                        Tope--;
                        return value;
                    }
                    else
                    {
                        act = act.Sig;
                    }
                }
            }
            return -1;
        } 
    } 
}