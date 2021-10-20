using System;

namespace ConsoleApp1
{
    class Pila
    {
        class Nodo
        {
            public int número;
            public Nodo siguiente;
        }

        private Nodo raíz;

        public void Insertar(int núm)
        {
            Nodo nuevo = new Nodo();
            nuevo.número = núm;
            if(raíz != null)
                nuevo.siguiente = raíz;
            else
                nuevo.siguiente = null;
            raíz = nuevo;
        }

        public int Extraer()
        {
            if (raíz != null)
            {
                int núm = raíz.número;
                raíz = raíz.siguiente;
                return núm;
            }
            else
                return int.MaxValue;
        }

        public void Imprimir()
        {
            Nodo reco = raíz;
            Console.Write("\n\nLos elementos de la pila: ");
            while(reco != null)
            {
                Console.Write(reco.número + ", ");
                reco = reco.siguiente;
            }
            return;
        }
        static void Main(string[] args)
        {
            Pila pila1 = new Pila();
            for(int i = 0; i < 6; i++)
            {
                Console.Write("Ingrese el " + (i + 1) + "º número: ");
                pila1.Insertar(Convert.ToInt32(Console.ReadLine()));
            }
            pila1.Imprimir();
            Console.ReadKey();
        }
    }
}
