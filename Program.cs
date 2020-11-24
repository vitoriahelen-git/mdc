using System;

namespace mdc
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorA; 
            int valorB;
            int mdc;
            bool encerrar = true; 
             

            Console.WriteLine("Máximo Divisor Comum");
            Console.Write("Digite o 1° número: "); 
            valorA = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Digite o 2° número: ");
            valorB = Convert.ToInt32(Console.ReadLine()); 

            while (encerrar)
            {
            if (valorA % valorB ==0)
            
            {
                Console.WriteLine($"MDC (a, b) = {valorA}");  
                encerrar = false;
            }
            else
            {
               mdc = valorA % valorB; 
               valorA = valorB; 
               valorB = mdc;  
               
            }
            }
 
        }
    }
}
