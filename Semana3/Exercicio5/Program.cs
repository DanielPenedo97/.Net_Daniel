/*Crie uma lista de tuplas, onde cada tupla contém o nome de uma pessoa e a sua altura em centímetros. 
Utilize uma expressão lambda e LINQ para calcular a altura média das pessoas na lista.*/

#region 

using System.Runtime.CompilerServices;

List<(String nome, int altura)> pessoas = new List<(String nome, int altura)>(){
        ("João", 180),
        ("Maria", 160),
        ("José", 170),
        ("Ana", 150),
        ("Pedro", 190),
        ("Mariana", 175),
        ("Carlos", 185),
        ("Amanda", 155),
        ("Bruno", 165),
    };

    Func<int, double> mediaAltura = x => x / pessoas.Count;
    {
        var mediaLista = pessoas.Select(p => p.altura).Average();
        Console.WriteLine($"A média de altura é: {mediaLista}");
    };

#endregion