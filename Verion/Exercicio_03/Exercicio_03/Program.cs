using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o CPF:");
            long cpf = long.Parse(Console.ReadLine());

            if (consultaCPF(cpf))
                Console.WriteLine("Cpf válido");

            else
                Console.WriteLine("Cpf inválido");

            Console.ReadKey();
        }

        public static bool consultaCPF(long cpf)
        {
            if (cpf.ToString().Length != 11)
                return false;


            #region variaveis
            string auxCpf = cpf.ToString();
            string[] sub = new string[auxCpf.Length];
            int [] digito = new int[auxCpf.Length];
            int inicial = 0;
            int[] multiplicador = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicardor2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3 };
            int digito1, digito2;
            int soma=0;
            int resultado, valorTemp;
            #endregion

            //pegando digitos           
            for (int x =0; x < auxCpf.Length; x++ )
            {
                sub[x] = auxCpf.Substring(inicial, 1);
                digito[x] = int.Parse(sub[x]);
                inicial++;
               
            }

            #region 1° digito
            for (int x = 0; x < 9; x++ )
            {
                soma += digito[x] * multiplicador[x];
            }

            valorTemp = (soma / 11)*11;

            resultado = soma - valorTemp;

            digito1 = 11 - resultado;
            #endregion

            #region 2° digito

            soma = 0;
            valorTemp = 0;

            for(int x =0; x<9; x++)
            {
                soma += digito[x] * multiplicardor2[x];
            }

            soma += digito1 * 2;

            valorTemp = (soma / 11) * 11;

            resultado = soma - valorTemp;

            digito2 = 11 - resultado;
            #endregion

            #region validação

            if (digito[9] == digito1 && digito[10] == digito2)
                return true;

            else
                return false;
            #endregion
            
        }
    }
}
