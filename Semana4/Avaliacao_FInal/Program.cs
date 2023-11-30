using System;
using System.Globalization;
using _Pessoa;
using _Advogados;
using _Cliente;
using System.Security.Cryptography.X509Certificates;


class Program{
    public static void Main(){
        CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("pt-BR");
        List<Advogados> advogados = new List<Advogados>(){
            new Advogados("João Advogado", new DateTime(1997, 2, 2), "12345678901", "CNA123"),
            new Advogados("Maria Advogada", new DateTime(1997, 2, 2), "23456789012", "CNA456"),
            new Advogados("Pedro Advogado", new DateTime(1997, 2, 2), "34567890123", "CNA789")
        };

        List<Cliente> clientes = new List<Cliente>(){
            new Cliente("João Cliente", new DateTime(1997, 2, 2), "12345678901", "Solteiro", "Programador"),
            new Cliente("Maria Cliente", new DateTime(1997, 2, 2), "23456789012", "Casado", "Programador"),
            new Cliente("Pedro Cliente", new DateTime(1997, 2, 2), "34567890123", "Solteiro", "Programador"),
            new Cliente("João Cliente", new DateTime(1997, 2, 2), "12345678901", "Solteiro", "Programador"),
        };


        Console.WriteLine("Advogados: ");
            foreach(Advogados advogado in advogados){
                Console.WriteLine($"Nome: {advogado.Nome}");
                Console.WriteLine($"CPF: {advogado.Cpf}");
            }
        Console.WriteLine("Clientes: ");
            foreach(Cliente cliente in clientes){
                Console.WriteLine($"Nome: {cliente.Nome}");
                Console.WriteLine($"CPF: {cliente.Cpf}");
            }
    }
}