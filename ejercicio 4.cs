using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {

            

            int[] datos = new int[10];




            int max = Int32.MinValue;
            for (int i = 0; i < datos.Length; i++)
            {
                Console.WriteLine("ingresa un numero entero");
                datos[i] = Convert.ToInt32(Console.ReadLine());

                if (datos[i] > max)
                    max = datos[i];
            }
            Console.WriteLine("el numero maximo es: {0}", max);
            { }



        }
    }
}