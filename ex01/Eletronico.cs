using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    public class Eletronico : Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Descricao { get; set; }

        public string Marca { get; set; }
        
        public Eletronico() { }

        public override double calculaPrecoFinal()
        {
            return Preco * 1.25;
        }
    }
}
