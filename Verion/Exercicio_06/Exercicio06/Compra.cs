using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio06
{
    class Compra
    {
        private int qtdLote;
        private int precoLote;
        private int dia;

        public int QtdLote { get { return qtdLote; } set { qtdLote = value; } }
        public int PrecoLote { get { return precoLote; } set { precoLote = value; } }
        public int Dia { get { return dia; } set { dia = value; } }


        public Compra(int qtdLote, int precoLote, int dia)
        {
            this.qtdLote = qtdLote;
            this.precoLote = precoLote;
            this.dia = dia;
        }

        public int dinheiroGasto()
        {
            return qtdLote * precoLote;
        }

        public void mostrarDados()
        {
            Console.WriteLine("Quantidade de lotes comprados no dia {0}: {1} lotes à {2}. Gasto total: {3}", 
                              this.dia, this.qtdLote, this.precoLote, dinheiroGasto());
        }
    }
}
