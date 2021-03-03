using System;

namespace ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {


            string texto;


            Console.Write("ingresa tu nombre ");
            
            texto = Convert.ToString(Console.ReadLine());
            string separador = texto;
            if (separador == texto)
            {

            }
            Console.Write("\n\r");
            for (int i = 0; i < separador.Length; i++)
            {
                Console.Write(separador[i] + " ");
            }
            Console.Write("\n\r");


        }
    }
}