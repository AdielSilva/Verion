using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 25, 160, 79, 54, 7, 25, 110, 84, 33, 2 };
            int contador = 0;

            Console.WriteLine("Digite o numero para conferir");
            int numeroEscolhido = int.Parse(Console.ReadLine());
            Console.WriteLine(metodoRecursivo(numeros, contador, numeroEscolhido));
            Console.ReadKey();
        }

        public static string metodoRecursivo(int[] numeros, int cont, int numero)
        {

            if (numeros.Count() > cont)
            {
                if (numeros[cont] == numero)
                    return "Numero " + numero + " existe";
            }

            else
            {
                cont++;
                metodoRecursivo(numeros, cont, numero);
            }

            return "Numero " + numero + " não existe";


        }

    }
}
