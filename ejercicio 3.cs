using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {


            int i = 1;

            while (i > 0 && i < 12)
            {
                int[] mes = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

               Console.WriteLine("**Digite el numero del mes** ");


                i = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n El mes que ha seleccionado tiene {0} dias", mes[i-1]);
                
            }

            
            
            
            




        }
    }
}
