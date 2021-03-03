using System;

namespace ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            


            int cont = 0;
            String[] nombre = new String[99];
           
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.Write("Ingrese El Nombre: {0} ", i + 1);
                String name = Console.ReadLine();
                if (name == string.Empty)
                {
                    break;
                }
                else
                {
                    nombre[i] = name;
                    cont++;
                }

            }
            for (int i = 0; i < cont; i++)
            {
                Console.WriteLine("los nombre registrado  son: *{0}*\n\r ", nombre[i]);
                
            }










        }
    }
}
