using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] problema = { 112, 114, 111, 118, 97, 58, 32, 116, 114, 97, 122, 101, 114, 32, 97, 108, 105, 109,
                                103, 111, 114, 105, 116, 109, 111, 32, 113, 117, 101, 32, 105, 109, 112, 114, 105, 32,
                                116, 111, 100, 111, 115, 32, 111, 115, 32, 110, 117, 109, 101, 114, 111, 115, 32, 112,114,
                                105, 109, 111, 115, 32, 101, 110, 116, 114, 101, 32, 48, 32, 101, 32, 49, 48, 48, 46};

            string byteTraduzido = System.Text.Encoding.ASCII.GetString(problema);
            Console.WriteLine(byteTraduzido);
            Console.ReadKey();


            
            
                for (int i = 2; i < 100; i++)
                {
                    if (i % 2 == 0 || i % 3== 0 || i % 5 == 0 || i % 7 == 0)
                    {

                        if (i == 2  || i == 3 || i == 5 || i == 7)
                            Console.WriteLine(i);
                    }
                    else
                        Console.WriteLine(i);              

                }

            Console.ReadKey();
        }
    }
}
