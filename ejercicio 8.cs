using System;

namespace ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] num = new float[5];
            float sum = 0;
            float media;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese el tamaño de la persona:  {0}: ", i + 1);
                num[i] = float.Parse(Console.ReadLine());
                sum += num[i];



            }
            media = sum / 5;
            


            for (int n = 0; n < 5; n++)
            {
                //Console.Write(" *{0}* ", num[n]);
            }
            Console.Write("el promedio de cada persona entre la altura es: {0}", media);




        }
    }
}
