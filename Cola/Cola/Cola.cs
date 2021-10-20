using System;

namespace Cola
{
    class Cola
    {
        class Nodo
        {
            public double número;
            public Nodo siguiente;
        }

        private Nodo raíz, fondo;

        public void Insertar(double núm)
        {
            Nodo nuevo = new Nodo();
            nuevo.número = núm;
            nuevo.siguiente = null;
            if(raíz == null)
            {
                raíz = nuevo;
                fondo = nuevo;
            }
            else
            {
                fondo.siguiente = nuevo;
                fondo = nuevo;
            }
        }

        public double Extraer()
        {
            if (raíz != null)
            {
                double núm = raíz.número;
                if (raíz == fondo)
                {
                    raíz = null;
                    fondo = null;
                }
                else
                    raíz = raíz.siguiente;
                return núm;
            }
            else
                return double.MaxValue;
        }

        public void Imprimir()
        {
            Nodo reco = raíz;
            Console.Write("Los elementos de la cola son: ");
            while (reco != null)
            {
                Console.Write(reco.número + ", ");
                reco = reco.siguiente;
            }
        }
        static void Main(string[] args)
        {
            Cola cola1 = new Cola();
            for(int i = 0; i < 6; i++)
            {
                Console.Write("Inserte el " + (i + 1) + "º número: ");
                cola1.Insertar(Convert.ToDouble(Console.ReadLine()));
            }
            Console.WriteLine();
            cola1.Imprimir();
            Console.ReadKey();
        }
    }
}
