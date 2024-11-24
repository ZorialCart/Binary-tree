namespace Binary_tree
{
    public class Nodo
    {
        public double Valor {  get; set; }
        public Nodo Izq { get; set; }

        public Nodo Der {  get; set; }

        public Nodo(double valor)
        {
            this.Valor = valor;
            Izq = null;
            Der = null;
        }

    }
}
