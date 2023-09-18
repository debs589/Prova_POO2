using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    public abstract class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Descricao { get; set; }

        public abstract double calculaPrecoFinal();
        
    }
}
