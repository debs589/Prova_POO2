# Exerc�cio 1
Imagine que voc� est� desenvolvendo um sistema de gerenciamento de produtos para uma loja online. Sua tarefa � criar classes e objetos para representar os elementos desse sistema. Aqui est�o os passos a seguir:
Defina uma classe chamada `Produto` que ser� a classe base para todos os tipos de produtos que a loja vende. Ela deve ter atributos e m�todos que se aplicam a todos os produtos, como nome, pre�o e descri��o, e um m�todo abstrato:
double calculaPrecoFinal()

Crie classes derivadas de `Produto` para representar tipos espec�ficos de produtos, como `Eletronico` e `Roupa`. Cada uma dessas classes deve ter atributos espec�ficos, como marca para eletr�nicos, tamanho para roupas, etc. A classe eletronico tem um pre�o final de pre�o + 25%. A classe Roupa possui pre�o final de pre�o + 35%.
Crie os testes do seu projeto

# Exerc�cio 2
Crie uma classe est�tica chamada Reflections e nessa classe crie um m�todo est�tico com o nome de RetornaCamposPublicos. Este m�todo receber� objeto (tipo object) e retornar� uma lista de strings com os nomes dos campos publicos pertencentes a esse objeto.
Crie os testes do seu projeto

# Exerc�cio 3
Crie uma classe chamada ObjetoComposto com dois tipos gen�ricos, um representar� uma Chave e o outro o Valor (como num dicion�rio). Essa classe possuir� 2 atributos, Chave e Valor, que ser� dos tipos que foram definidos ao instanciar a classe e receber�o seus respectivos valores. Nessa classe, crie um m�todo chamado Exibir, onde ser� retornada uma string contendo o nome da chave e seu valor.

Exemplo:

ObjetoComposto<string, string> meuObj = new ObjetoComposto<string, string>()
meuObj.Chave = "Essa � a chave";
meuObj.Valor = "Esse � o valor";

meuObj.Exibir() => "Chave: Essa � a chave Valor: Esse � o valor"

# Exerc�cio 4
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
            return "Cliente com e-mail inv�lido";

        if (CPF.Length != 11)
            return "Cliente com CPF inv�lido";


        string connectionString = "MinhaConnectionString";
        string commandText = "INSERT INTO CLIENTE (NOME, EMAIL CPF) VALUES (@nome, @email, @cpf))";

        var parameters = new Dictionary<string, string>();
        parameters.Add("nome", Nome);
        parameters.Add("email", Email);
        parameters.Add("cpf", CPF);

        //Abrindo conex�o e gravar na base...

        var mail = "empresa@empresa.com";
        var assunto = "Bem Vindo.";
        var corpo = "Parab�ns! Voc� est� cadastrado.";
        
        //Enviando email...

        return "Cliente cadastrado com sucesso!";
    }
}

# Exerc�cio 5
Imagine que voc� est� desenvolvendo um sistema de desconto para um site de com�rcio eletr�nico. Atualmente, voc� tem uma classe chamada `CalculadoraDesconto` que calcula descontos com base no tipo de cliente e no valor total da compra.

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

Adicione um novo tipo de cliente, como "VIP", sem adicionar uma nova condi��o a classe CalculadoraDesconto.

# Exerc�cio 6
O que significa o Princ�pio da Responsabilidade �nica?  
Descreva com suas palavras a rela��o entre a viola��o deste princ�pio e o acoplamento �ruim�.  

# Exerc�cio 7
Quando usamos, por exemplo, heran�a de classes para adicionar comportamentos ao sistema sem que para isso tenhamos que alterar a classe estendida, qual dos cinco princ�pios SOLID estamos�respeitando?

# Exerc�cio 8
Qual a rela��o entre o Princ�pio da Substitui��o de Liskov e Polimorfismo?

# Exerc�cio 9
Qual a rela��o entre o Princ�pio da Invers�o de Depend�ncia e Inje��o de Depend�ncia?

# Exerc�cio 10
Classifique as afirma��es a seguir como Verdadeiras ou Falsas.  

Uma classe abstrata pode ser instanciada.  
( ) Verdadeiro  
( ) Falso  

Uma classe abstrata pode ter m�todo n�o abstratos.  
( ) Verdadeiro  
( ) Falso  

Uma classe derivada da classe abstrata obrigatoriamente deve implementar os m�todos abstratos.  
( ) Verdadeiro  
( ) Falso  

A interface � um tipo de heran�a, ou seja, os objetos instanciados de uma interface s�o uma interface.  
( ) Verdadeiro  
( ) Falso  

Os contratos da interface n�o s�o obrigat�rios de implementa��o.  
( ) Verdadeiro  
( ) Falso  

Um dos principais benef�cios do uso de interfaces � que elas permitem testes e manuten��o de c�digo mais f�ceis  
( ) Verdadeiro  
( ) Falso  

Outra vantagem do uso de interfaces � que elas promovem um acoplamento fraco entre classes  
( ) Verdadeiro  
( ) Falso  

A utiliza��o de Reflection s� traz benef�cios para o c�digo, pois ajuda a deix�-los mais r�pido.  
( ) Verdadeiro  
( ) Falso  

� poss�vel instanciar objetos em tempo de execu��o com Reflection  
( ) Verdadeiro  
( ) Falso  

O Generic possibilita uma versatilidade nos tipos, e ainda garante um tipagem segura  
( ) Verdadeiro  
( ) Falso  

Generics � utilizado para escrita de c�digos�reutiliz�veis.  
( ) Verdadeiro  
( ) Falso 