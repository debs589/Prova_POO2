namespace ex03
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public class ObjetoComposto<T>
        {
            public T Chave { get; set; }
            public T Valor { get; set;}

            public string Exibir()
            {
                return $"Chave: {Chave} | Valor: {Valor}";
            }
        }

    }
}