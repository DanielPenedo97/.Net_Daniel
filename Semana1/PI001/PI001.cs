//Problema: Quais são os tipos de dados numéricos inteiros disponíveis no .NET? Dê
//exemplos de uso para cada um deles através de exemplos.

#region Tipo de dados


// Tipo de dado: int
// Faixa de valores: -2.147.483.648 a 2.147.483.647

int idade = 25;
Console.WriteLine("Idade: " + idade);

// Tipo de dado: uint
// Faixa de valores: 0 a 4.294.967.295
uint quantidadeProdutos = 100;
Console.WriteLine("Quantidade de produtos: " + quantidadeProdutos);

// Tipo de dado: short
// Faixa de valores: -32.768 a 32.767
short temperatura = -10;
Console.WriteLine("Temperatura: " + temperatura);

// Tipo de dado: ushort
// Faixa de valores: 0 a 65.535
ushort contagem = 5000;
Console.WriteLine("Contagem: " + contagem);

// Tipo de dado: long
// Faixa de valores: -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807
long populacaoMundial = 7_900_000_000;
Console.WriteLine("População Mundial: " + populacaoMundial);

// Tipo de dado: ulong 
//Faixa de valores: 0 a 18.446.744.073.709.551.615
ulong totalBytes = 1_000_000_000_000;
Console.WriteLine("Total de Bytes: " + totalBytes);

#endregion

/*Problema: Suponha que você tenha uma variável do tipo double e deseja convertê-la
em um tipo int. Como você faria essa conversão e o que aconteceria se a parte
fracionária da variável double não pudesse ser convertida em um int? Resolva o
problema através de um exemplo em C#*/

#region Conversão double pra int

 // Variável do tipo double com parte fracionária
double numeroDouble = 10.75;
Console.WriteLine("Número double: " + numeroDouble);

// Conversão para int (parte fracionária será perdida na conversão)
int numeroInteiro = (int)numeroDouble;
Console.WriteLine("Número inteiro após conversão: " + numeroInteiro);

#endregion

//Problema: Dada a variável int x = 10 e a variável int y = 3, escreva código para calcular
//e exibir o resultado da adição, subtração, multiplicação e divisão de x por y.

#region Soma, subtração, multiplicação, divisão

int x = 10;
int y = 3;

// Adição
int soma = x + y;
Console.WriteLine("Soma: " + soma);

// Subtração
int subtracao = x - y;
Console.WriteLine("Subtração: " + subtracao);

// Multiplicação
int multiplicacao = x * y;
Console.WriteLine("Multiplicação: " + multiplicacao);

// Divisão
int divisao = x / y;
Console.WriteLine("Divisão: " + divisao);

#endregion


//Problema: Considere as variáveis int a = 5 e int b = 8. Escreva código para determinar
//se a é maior que b e exiba o resultado.

#region Maior que

// Variáveis
int a = 5;
int b = 8;

// Verifica se 'a' é maior que 'b'
if (a > b)
    Console.WriteLine("a é maior que b.");
else
    Console.WriteLine("a não é maior que b.");

#endregion

//Problema: Você tem duas strings, string str1 = "Hello" e string str2 = "World". Escreva
//código para verificar se as duas strings são iguais e exibir o resultado.

#region Strings iguais

// Duas strings
string str1 = "Hello";
string str2 = "World";

// Verifica se as duas strings são iguais
// Comparação usando o método Equals
if (str1.Equals(str2))
    Console.WriteLine("As strings são iguais usando o método Equals.");
else
    Console.WriteLine("As strings não são iguais usando o método Equals.");
// Comparação usando o operador de igualdade (==)
if (str1 == str2)
    Console.WriteLine("As strings são iguais usando o operador de igualdade.");
else
    Console.WriteLine("As strings não são iguais usando o operador de igualdade.");

#endregion

//Problema: Suponha que você tenha duas variáveis booleanas, bool condicao1 = true
//e bool condicao2 = false. Escreva código para verificar se ambas as condições são
//verdadeiras e exiba o resultado

#region Operador Boolean

// Duas variáveis booleanas
bool condicao1 = true;
bool condicao2 = false;

// Verifica se ambas as condições são verdadeiras usando o operador &&
if (condicao1 && condicao2)
    Console.WriteLine("Ambas as condições são verdadeiras.");
else
    Console.WriteLine("Pelo menos uma das condições não é verdadeira.");

#endregion

//Problema: Dadas as variáveis int num1 = 7, int num2 = 3, e int num3 = 10, escreva
//código para verificar se num1 é maior do que num2 e se num3 é igual a num1 + num2.

#region 

// Variáveis
int num1 = 7;
int num2 = 3;
int num3 = 10;

// Verifica se num1 é maior que num2
bool con1 = num1 > num2;

// Verifica se num3 é igual a num1 + num2
bool con2 = num3 == (num1 + num2);

// Verifica ambas as condições
if (con1 && con2)
    Console.WriteLine("Ambas as condições são verdadeiras.");

//verifica se só a primeira é verdadeira
else if (con1)
    Console.WriteLine("num1 é maior que num2.");
    //verifica se só a segunda é verdadeira
    else if (con2)
        Console.WriteLine("num3 é igual a num1 + num2.");
        //printa que as duas são falsas
        else
            Console.WriteLine("As condições não são atendidas.");

#endregion