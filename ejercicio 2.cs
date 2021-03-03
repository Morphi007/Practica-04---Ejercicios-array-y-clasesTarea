using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {


             int i;
            float[] num = new float[5];
            

            Console.WriteLine("escriba 5 numero reales");

            for (i = 0; i < 5; i++)
            {

                Console.WriteLine("**ingresa un numero entero** {0}", i);

                num[i]=float.Parse(Console.ReadLine());

            }

            for (i = 4; i >= 0; i--)
            {

                Console.WriteLine("\n\n numero contrarios {0}",num[i]);
                
            }




        }
    }
}