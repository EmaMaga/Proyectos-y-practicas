using System;
using System.Threading.Channels;
namespace Curso_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //El numero ya se encuentra asociado a un paquete
            int numeroPackete = 1234;
            bool accept=false;
            Console.WriteLine("Escriba su numero de paquete");
            while (accept == false)
            {
                try
                {
                    int PN = Int32.Parse(Console.ReadLine());
                    //Metodo que comprueba el numero puesto con el numero del paquete
                    ComprovacionPN(PN, numeroPackete);                    
                    accept= true;
                }
                catch (Exception e) when (e.GetType() != typeof(FormatException)) 
                { Console.WriteLine("El numero que agrego es demaciado grande."); accept = false; }
                catch (FormatException e)
                {
                    Console.WriteLine("Solo Numeros porfavor.");
                    accept = false;
                }
            }

        }
        //Este seria el metodo
        public static void ComprovacionPN(int PN, int numeroPackete)
        {
            while (PN != numeroPackete)
            {
                Console.WriteLine("Intentelo de nuevo");
                PN =Int32.Parse(Console.ReadLine());
                
            }
            Console.WriteLine("Codigo correcto");


        }
    }
}
