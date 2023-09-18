namespace ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Eletronico eletronico = new Eletronico();
            eletronico.Nome = "Notebook";
            eletronico.Descricao = "computador portátil";
            eletronico.Marca = "Dell";
            eletronico.Preco = 100;
            Console.WriteLine(eletronico.calculaPrecoFinal());

            Roupa roupa = new Roupa();
            roupa.Preco = 100;
            Console.WriteLine(roupa.calculaPrecoFinal());
        }
    }
}