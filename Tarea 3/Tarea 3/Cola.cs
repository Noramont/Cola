using System;

namespace Tarea_3
{
    class Cola
    {
        class Nodo
        {
            public string frase;
            public Nodo siguiente;
        }

        private Nodo raíz, fondo;

        public void Insertar(string fraseNueva)
        {
            Nodo nuevo = new Nodo();
            nuevo.frase = fraseNueva;
            nuevo.siguiente = null;
            if (raíz == null)
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

        public string Extraer()
        {
            if (raíz != null)
            {
                string núm = raíz.frase;
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
                return "";
        }

        public void Imprimir()
        {
            Nodo reco = raíz;
            Console.Write("\n\nLas frases ingresadas son:\n\n");
            while (reco != null)
            {
                Console.Write("* "+reco.frase + "\n");
                reco = reco.siguiente;
            }
        }
        static void Main(string[] args)
        {
            string frase;
            Cola cola1 = new Cola();
            do
            {
                Console.Write("Ingrese una frase: ");
                frase = Console.ReadLine();
                if(frase != "")
                    cola1.Insertar(frase);
            } while (frase != "");
            cola1.Imprimir();
            Console.ReadKey();
        }
    }
}
