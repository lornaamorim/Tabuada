using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a tabuada: ");
            int tab = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de vezes: ");
            int vezes = int.Parse(Console.ReadLine());

            int cont = 1;

            while (cont <= vezes)
            {
                int resultado = tab * cont;
                Console.WriteLine(tab + "X" + cont + "=" + resultado);
                cont ++;
            }

            Console.ReadKey();
        }
    }
}
