using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> lote = new Queue<int>();
            List<Compra> compras = new List<Compra>();


            int[] qtd = new int [3];
            int[] preco = { 30, 35, 20 };
            int[] dia = new int[3];
            int lucroTotal = 0;

            for (int x = 0; x < dia.Count(); x++)
            {
                Console.WriteLine("Os lotes estão custando {0}R$", preco[x]);
                Console.Write("Quantos lotes deseja comprar?  ");
                qtd[x] = int.Parse(Console.ReadLine());

                for (int y = 0; y < qtd[x]; y++)
                {
                    lote.Enqueue(preco[x]);
                }

                dia[x] = x+1;

                compras.Add(new Compra(qtd[x], preco[x], dia[x]));

                Console.WriteLine("Compra concluida");
                Console.ReadKey();
                Console.Clear();
            }
            
            foreach (Compra s in compras)
            {
                s.mostrarDados();
                
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Deseja vender quantos lotes á quanto?");
            Console.Write("Quantidade: ");
            int quantidadeVendido = int.Parse(Console.ReadLine());
            Console.Write("\nPreço: ");
            int precoVendido = int.Parse(Console.ReadLine());

            

            for (int x = 0; x < quantidadeVendido; x++)
            {
                while (lote.Count() != 0)
                    lucroTotal += (precoVendido - lote.Dequeue());
                
            }

            if (lucroTotal < 0)
                Console.WriteLine("Saldo negativo de {0} R$" , lucroTotal);


            else
                Console.WriteLine("Lucro total: {0}R$ " , lucroTotal);


           
            Console.ReadKey();
        }
    }
}
