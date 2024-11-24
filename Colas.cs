using System;

namespace Binary_tree
{
    public class Colas
    {
        private NodoNormy inicio;
        private int count = 0;
        private double max;
        private double valor;
        public NodoNormy Inicio { get => inicio; set => inicio = value; }
        public int Countt { get => count; set => count = value; }
        public double Max { get => max; set => max = value; }
        public double Valor { get => valor; set => valor = value; }
        public Colas(int max)
        {
            Max = max;
            Inicio = null;
        }
        public bool UnderFlow()
        {
            //Válida que la cola esté vacía
            if (Inicio == null)
                return true;
            else
                return false;
        }
        private bool OverFlow()
        {
            //Válida si la cola está llena
            if (Countt == Max)
                return true;
            else
                return false;
        }
        public void Print()
        {
            if (this.UnderFlow())
            {
                Console.WriteLine("\n¡LA COLA ESTÁ VACÍA!");
            }
            NodoNormy actual = Inicio;
            while (actual != null)
            {
                Console.WriteLine(actual.Valor);
                actual = actual.Sig;
            }
        }

        public bool Insert(double num)
        {
            NodoNormy nuevo = new NodoNormy((int)num);
            if (this.OverFlow())
            {
                return false;
            }
            if (Inicio == null)
            {
                Inicio = nuevo;
                Countt++;
                return true;
            }
            NodoNormy actual = Inicio;
            while (actual.Sig != null)
            {
                actual = actual.Sig;
            }
            actual.Sig = nuevo;
            Countt++;
            return true;
        }
        public double Extract()
        {
            // Regresa el valor extraido de la cola, si la cola esta vacia regresa -1.
        if (this.UnderFlow())
            {
                return -1;
            }
            double extraer = Inicio.Valor;
            Inicio = Inicio.Sig;
            Countt--;
            return extraer;
        }
    }
}