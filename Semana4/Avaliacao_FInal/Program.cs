using System;
using System.Globalization;
using _Pessoa;
using _Advogados;
using _Cliente;
using System.Security.Cryptography.X509Certificates;

CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("pt-BR");

#region Herança

class Principal{
    static void Main(){
        List<Advogados> advogados = new List<Advogados>(){
            new Advogados("João Advogado", new DateTime(1, 1, 2001), "12345678901", "CNA123"),
            new Advogados("Maria Advogada", new DateTime(03, 06, 2000), "23456789012", "CNA456"),
            new Advogados("Pedro Advogado", new DateTime(2, 7, 1997), "34567890123", "CNA789")
        };

        List<Cliente> clientes = new List<Cliente>(){
            new Cliente("João Cliente", new DateTime(1, 1, 2001), "12345678901", "Solteiro", "Programador"),
            new Cliente("Maria Cliente", new DateTime(03, 06, 2000), "23456789012", "Casado", "Programador"),
            new Cliente("Pedro Cliente", new DateTime(2, 7, 1997), "34567890123", "Solteiro", "Programador")
        };
        
    Console.WriteLine("Advogados: ");
        foreach(Advogados advogado in advogados){
            Console.WriteLine($"Nome: {advogado.Nome}");
            Console.WriteLine($"CPF: {advogado.Cpf}");
        }
    
    }

}
#endregion