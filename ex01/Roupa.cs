using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    public class Roupa : Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Descricao { get; set; }

        public string Tamanho { get; set; }

        public Roupa() { }

        public override double calculaPrecoFinal()
        {
            return Preco * 1.35;
        }
    }
}
