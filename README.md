# Exercício 1
Imagine que você está desenvolvendo um sistema de gerenciamento de produtos para uma loja online. Sua tarefa é criar classes e objetos para representar os elementos desse sistema. Aqui estão os passos a seguir:
Defina uma classe chamada `Produto` que será a classe base para todos os tipos de produtos que a loja vende. Ela deve ter atributos e métodos que se aplicam a todos os produtos, como nome, preço e descrição, e um método abstrato:
double calculaPrecoFinal()

Crie classes derivadas de `Produto` para representar tipos específicos de produtos, como `Eletronico` e `Roupa`. Cada uma dessas classes deve ter atributos específicos, como marca para eletrônicos, tamanho para roupas, etc. A classe eletronico tem um preço final de preço + 25%. A classe Roupa possui preço final de preço + 35%.
Crie os testes do seu projeto

# Exercício 2
Crie uma classe estática chamada Reflections e nessa classe crie um método estático com o nome de RetornaCamposPublicos. Este método receberá objeto (tipo object) e retornará uma lista de strings com os nomes dos campos publicos pertencentes a esse objeto.
Crie os testes do seu projeto

# Exercício 3
Crie uma classe chamada ObjetoComposto com dois tipos genéricos, um representará uma Chave e o outro o Valor (como num dicionário). Essa classe possuirá 2 atributos, Chave e Valor, que será dos tipos que foram definidos ao instanciar a classe e receberão seus respectivos valores. Nessa classe, crie um método chamado Exibir, onde será retornada uma string contendo o nome da chave e seu valor.

Exemplo:

ObjetoComposto<string, string> meuObj = new ObjetoComposto<string, string>()
meuObj.Chave = "Essa é a chave";
meuObj.Valor = "Esse é o valor";

meuObj.Exibir() => "Chave: Essa é a chave Valor: Esse é o valor"

# Exercício 4
Refatore a classe abaixo para respeitar os principios do SOLID:
public class Cliente
{
    public int ClienteId { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string CPF { get; set; }

    public string AdicionarCliente()
    {
        if (!Email.Contains("@"))
            return "Cliente com e-mail inválido";

        if (CPF.Length != 11)
            return "Cliente com CPF inválido";


        string connectionString = "MinhaConnectionString";
        string commandText = "INSERT INTO CLIENTE (NOME, EMAIL CPF) VALUES (@nome, @email, @cpf))";

        var parameters = new Dictionary<string, string>();
        parameters.Add("nome", Nome);
        parameters.Add("email", Email);
        parameters.Add("cpf", CPF);

        //Abrindo conexão e gravar na base...

        var mail = "empresa@empresa.com";
        var assunto = "Bem Vindo.";
        var corpo = "Parabéns! Você está cadastrado.";
        
        //Enviando email...

        return "Cliente cadastrado com sucesso!";
    }
}

# Exercício 5
Imagine que você está desenvolvendo um sistema de desconto para um site de comércio eletrônico. Atualmente, você tem uma classe chamada `CalculadoraDesconto` que calcula descontos com base no tipo de cliente e no valor total da compra.

```
public class CalculadoraDesconto
{
    public decimal CalcularDesconto(decimal valorTotal, string tipoCliente)
    {
        if (tipoCliente == "novo")
        {
            return valorTotal * 0.1;
        }
        else if (tipoCliente = "premium")
        {
            return valorTotal * 0.2;
        }
        else
            return 0;
    }
}
```

Adicione um novo tipo de cliente, como "VIP", sem adicionar uma nova condição a classe CalculadoraDesconto.

# Exercício 6
O que significa o Princípio da Responsabilidade Única?  
Descreva com suas palavras a relação entre a violação deste princípio e o acoplamento “ruim”.  

# Exercício 7
Quando usamos, por exemplo, herança de classes para adicionar comportamentos ao sistema sem que para isso tenhamos que alterar a classe estendida, qual dos cinco princípios SOLID estamos respeitando?

# Exercício 8
Qual a relação entre o Princípio da Substituição de Liskov e Polimorfismo?

# Exercício 9
Qual a relação entre o Princípio da Inversão de Dependência e Injeção de Dependência?

# Exercício 10
Classifique as afirmações a seguir como Verdadeiras ou Falsas.  

Uma classe abstrata pode ser instanciada.  
( ) Verdadeiro  
( ) Falso  

Uma classe abstrata pode ter método não abstratos.  
( ) Verdadeiro  
( ) Falso  

Uma classe derivada da classe abstrata obrigatoriamente deve implementar os métodos abstratos.  
( ) Verdadeiro  
( ) Falso  

A interface é um tipo de herança, ou seja, os objetos instanciados de uma interface são uma interface.  
( ) Verdadeiro  
( ) Falso  

Os contratos da interface não são obrigatórios de implementação.  
( ) Verdadeiro  
( ) Falso  

Um dos principais benefícios do uso de interfaces é que elas permitem testes e manutenção de código mais fáceis  
( ) Verdadeiro  
( ) Falso  

Outra vantagem do uso de interfaces é que elas promovem um acoplamento fraco entre classes  
( ) Verdadeiro  
( ) Falso  

A utilização de Reflection só traz benefícios para o código, pois ajuda a deixá-los mais rápido.  
( ) Verdadeiro  
( ) Falso  

É possível instanciar objetos em tempo de execução com Reflection  
( ) Verdadeiro  
( ) Falso  

O Generic possibilita uma versatilidade nos tipos, e ainda garante um tipagem segura  
( ) Verdadeiro  
( ) Falso  

Generics é utilizado para escrita de códigos reutilizáveis.  
( ) Verdadeiro  
( ) Falso 