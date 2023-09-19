using System.Collections;
using System.Collections.Generic;

namespace ex02
{
    public class Program
    {
        static void Main(string[] args)
        {
            AlgumaClasse Objeto = new();
            Objeto.CampoX = 1;
            Reflections.RetornaCamposPublicos(Objeto);
        }

        public class AlgumaClasse
        {
            public int CampoX;
            private int CampoY;
            public int Propriedade1 { get; set; }
            private int Propriedade2 { get; set; }

            public AlgumaClasse() { }
            public string Metodo1()
            {
                return "Método1 chamado";
            }

            private string Metodo2()
            {
                return "Method2 chamado";
            }
        }
        public static class Reflections
        {
            public static void RetornaCamposPublicos(object obj)
            {
                
                    var tipo = obj.GetType().GetFields();

            }

        }

    }      
}