using System;

namespace Binary_tree
{
    public class Listas
    {
        NodoNormy inicio;

        public Listas()
        {
            inicio = null;
        }

        public void Add(int num)
        {
            NodoNormy nuevo = new NodoNormy(num);
            if (inicio == null)
            {
                inicio = nuevo;
            }
            else
            {
                NodoNormy act = inicio;
                while (act.Sig != null)
                    act = act.Sig;

                act.Sig = nuevo;

            }
        }

        public void Print()
        {
            if (inicio == null)
                Console.WriteLine("Lista vacía");
            else
            {
                NodoNormy act;
                act = inicio;
                while (act != null)
                {
                    Console.Write($"{act.Valor}");
                    act = act.Sig;
                }
            }
        }
        public int Find(int pos)
        {
           
        if (inicio == null || pos < 0)
            {
                return -1;
            }

            NodoNormy actual = inicio;

            int cont = 0;

            while (actual != null)
            {
                if (cont == pos)
                {
                    return (int)actual.Valor;
                }
                cont++;
                actual = actual.Sig;
            }
            return -1;

        }

        public bool Delete(int pos)
        {
            
        if (inicio == null || pos < 0)
            {
                return false;
            }
            if (pos == 0)
            {
                inicio = inicio.Sig;
                return true;
            }

            NodoNormy actual = inicio;
            for (int i = 0; i < pos - 1; i++)
            {
                if (actual == null || actual.Sig == null)
                {
                    return false;
                }
                actual = actual.Sig;
            }
            if (actual.Sig == null)
            {
                return false;
            }
            actual.Sig = actual.Sig.Sig;
            return true;
        }
        public bool Change(int pos, int num)
        {
            
        if (inicio == null || pos < 0)
            {
                return false;
            }
            NodoNormy actual = inicio;
            int cont = 0;

            while (actual != null)
            {

                if (cont == pos)
                {
                    actual.Valor = num;
                    return true;
                }
                cont++;
                actual = actual.Sig;

            }
            return false;
        }

        public int Count()
        {
            
            int contador = 0;
            NodoNormy actual = inicio;
            if (actual == null)
            {
                Console.WriteLine("La lista está vacía.");
            }
            else
            {
                while (actual != null)
                {
                    contador++;
                    actual = actual.Sig;
                }
            }

            return contador;

        }

        public int FindValue(int num)
        {
            if (inicio == null)
            {
                return -1;
            }

            NodoNormy actual = inicio;
            int cont = 0;
            while (actual != null)
            {
                if (actual.Valor.Equals(num))
                {
                    return cont;
                }
                cont++;
                actual = actual.Sig;

            }
            return -1;
        }

        public void DrawScreen(Listas lista)
        {
            string line = "";
            string valu = "";

            int draw = lista.Count();
            if (draw == 0)
            {
                string[] print = new string[]
                {
                    $"┌--------------------┬┐ ",
                    $"| chanchito tiste :C ||-┐",
                    $"└--------------------┴┘-┴-"
                };

                foreach (string str in print)
                {
                    Console.WriteLine(str);
                }
                return;
            }

            for (int i = 0; i < draw; i++)
            {
                for (int j = 0; j < draw; j++)
                {
                    valu = lista.Find(j).ToString();
                    line = line.PadRight(valu.Length);
                    line.Replace(" ", "-");

                    string[] printEnd = new string[]
                    {
                        $"┌{line}┬┐     ",
                        $"|{valu}||--┐  ",
                        $"└{line}┴┘ -┴- "
                    };

                    string[] dcontinue = new string[]
                    {
                        $"┌{line}┬┐   ",
                        $"|{valu}||==>",
                        $"└{line}┴┘   "
                    };

                    if (draw - 1 == j)
                    {
                        Console.Write(printEnd[i]);
                    }
                    else
                    {
                        Console.Write(dcontinue[i]);
                    }
                    line = "";
                }
                Console.WriteLine();
            }
        }
    }
}

