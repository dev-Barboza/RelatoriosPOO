using System;

namespace Polimorfismo1
{
    class Program
    {
        static void Main(string[] args)
        {
           System.Console.WriteLine("Mensal:");
           
           Mensal m = new Mensal();
           m.mostrarRelatorio();

           Anual a = new Anual();
           a.mostrarRelatorio();
        
        }
    }
}
