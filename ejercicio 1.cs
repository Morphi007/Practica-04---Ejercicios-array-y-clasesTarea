using System;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
           double []num = new double[4];
            double sum = 0;
            double media;
         
            for (int i = 0;i < 4; i++)
            {
                Console.Write("Ingrese un numero {0}: ",i + 1);
                num[i] = Convert.ToDouble(Console.ReadLine());
                sum += num[i];

               

            }
            media = sum / 4;
            Console.Write("Los numeros ingresados son: ");


            for(int n = 0; n < 4; n++)
            {
                Console.Write(" *{0}* ", num[n]);
            }
            Console.Write("Y la media aritmetica es: {0}", media);




        }
    }
}
