using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Parte2_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int sucessor = 0;

            Console.Write("Digite um Número para saber o seu Sucessor: ");
            numero = int.Parse(Console.ReadLine());

            sucessor = numero + 1;

            Console.WriteLine("O Sucessor do Número {0} é {1}", numero, sucessor);
        }
    }
}
