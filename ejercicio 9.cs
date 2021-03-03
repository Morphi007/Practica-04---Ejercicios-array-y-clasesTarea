using System;

namespace ejercicio_9
{
    class TablaMultiplicar
    {


        public void CargarValor()
        {
            int valor;
            string linea;
            do
            {
                Console.Write("Ingrese un valor (-1 para finalizar):");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                if (valor != -1)
                {
                    Calcular(valor);
                }
            } while (valor != -1);
        }



        public void Calcular(int num)
        {

            for (int i = num; i <= num; i++)
            {
                Console.WriteLine("\nTabla de multiplicar del {0}", i);
                Console.WriteLine("------------------------------");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} * {1} = {2}", i, j, (i * j));
                }



            }
            Console.WriteLine();
        }




        static void Main(string[] args)
        {
            TablaMultiplicar teblo = new TablaMultiplicar();
            teblo.CargarValor();











        }
    }
}

