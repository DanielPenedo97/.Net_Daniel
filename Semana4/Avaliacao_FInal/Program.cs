using System;
using System.Globalization;
using _Pessoa;
using _Advogados;
using _Cliente;

CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("pt-BR");

#region Herança

class Principal{
    static void Main(){
        Cliente cliente = new Cliente("Valber", "10/10/1990", "123456789-00", "Solteiro", "Programador");
        Advogados advogado = new Advogados("Helder", "10/10/1990", "123456789-00", "123456789-00");
        Console.WriteLine(cliente.Nome);
        Console.WriteLine(advogado.Nome);

        
    }
}
#endregion