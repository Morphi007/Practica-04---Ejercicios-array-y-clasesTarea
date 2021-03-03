using System;

namespace ejercicio_10
{
    class Program
    {



        private string nombre;
        private int edad;

        public void preguntar()
        {

            Console.WriteLine("Ingresa tu Nombre ");
            nombre = Console.ReadLine();
            
            Console.WriteLine("ingresa tu edad: {0}",nombre);
            edad = Convert.ToInt32(Console.ReadLine());
            
            


        }

        public void verificaedad()
        {

            if (edad>=18)
            {
                Console.WriteLine($"Bienvenido: {nombre}. puede disfrutar de nuestro contenido ;)");
            }
            else
            {
                Console.WriteLine("no eres mayor de edad: {0}.", nombre);
            }
 
        }





        static void Main(string[] args)
        {

            Program registro = new Program();


            registro.preguntar();
            registro.verificaedad();


        }
   
    
    
    }
}
