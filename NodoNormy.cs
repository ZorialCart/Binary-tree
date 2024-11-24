namespace Binary_tree
{
    public class NodoNormy
    {
        private double valor;
        private NodoNormy sig;

        public NodoNormy(int valor)
        {
            this.valor = valor;
            sig = null; 
        }

        public double Valor
        {
            get => valor;
            set => valor = value;
        }

        public NodoNormy Sig
        {
            get => sig;
            set => sig = value;
        }
    }
}