using System;
using System.Globalization;
using _Pessoa;
using _Advogados;
using _Cliente;
using System.Security.Cryptography.X509Certificates;

/*Relatórios:
1. Advogados com idade entre dois valores
2. Clientes com idade entre dois valores
3. Clientes com estado civil informado pelo usuário
4. Clientes em ordem alfabética
5. Clientes cuja profissão contenha texto informado pelo usuário
6. Advogados e Clientes aniversariantes do mês informado
Dicas:
• Utilize expressões lambda para consultas.
• Implemente consultas LINQ para gerar os relatórios.
• Utilize tratamento de exceções para garantir uma experiência de usuário mais
robusta e amigável*/


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
                Console.WriteLine($"Nome: {advogado.nome}");
                Console.WriteLine($"CPF: {advogado.cpf}");
            }
        Console.WriteLine("Clientes: ");
            foreach(Cliente cliente in clientes){
                Console.WriteLine($"Nome: {cliente.nome}");
                Console.WriteLine($"CPF: {cliente.cpf}");
            }
        
        Console.WriteLine("Digite a opção desejada: ");
        Console.WriteLine("1. Advogados com idade entre dois valores");
        Console.WriteLine("2. Clientes com idade entre dois valores");
        Console.WriteLine("3. Clientes com estado civil informado pelo usuário");
        Console.WriteLine("4. Clientes em ordem alfabética");
        Console.WriteLine("5. Clientes cuja profissão contenha texto informado pelo usuário");
        Console.WriteLine("6. Advogados e Clientes aniversariantes do mês informado");
        int opcao = int.Parse(Console.ReadLine());

        switch(opcao){
            case 1:
                Console.WriteLine("Digite a idade mínima: ");
                int idadeMinima = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a idade máxima: ");
                int idadeMaxima = int.Parse(Console.ReadLine());
                var advogadosIdade = advogados.Where(a => a.dataDeNascimento.Year >= idadeMinima && a.dataDeNascimento.Year <= idadeMaxima);
                foreach(Advogados advogado in advogadosIdade){
                    Console.WriteLine($"Nome: {advogado.nome}");
                    Console.WriteLine($"CPF: {advogado.cpf}");
                }
                break;
            case 2:
                Console.WriteLine("Digite a idade mínima: ");
                int idadeMinima2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a idade máxima: ");
                int idadeMaxima2 = int.Parse(Console.ReadLine());
                var clientesIdade = clientes.Where(c => c.dataDeNascimento.Year >= idadeMinima2 && c.dataDeNascimento.Year <= idadeMaxima2);
                foreach(Cliente cliente in clientesIdade){
                    Console.WriteLine($"Nome: {cliente.nome}");
                    Console.WriteLine($"CPF: {cliente.cpf}");
                }
                break;
            case 3:
                Console.WriteLine("Digite o estado civil: ");
                string estadoCivil = Console.ReadLine();
                var clientesEstadoCivil = clientes.Where(c => c.estadoCivil == estadoCivil);
                foreach(Cliente cliente in clientesEstadoCivil){
                    Console.WriteLine($"Nome: {cliente.nome}");
                    Console.WriteLine($"CPF: {cliente.cpf}");
                }
                break;
            case 4:
                var clientesOrdemAlfabetica = clientes.OrderBy(c => c.nome);
                foreach(Cliente cliente in clientesOrdemAlfabetica){
                    Console.WriteLine($"Nome: {cliente.nome}");
                    Console.WriteLine($"CPF: {cliente.cpf}");
                }
                break;
            case 5:
                Console.WriteLine("Digite a profissão: ");
                string profissao = Console.ReadLine();
                var clientesProfissao = clientes.Where(c => c.profissao.Contains(profissao));
                foreach(Cliente cliente in clientesProfissao){
                    Console.WriteLine($"Nome: {cliente.nome}");
                    Console.WriteLine($"CPF: {cliente.cpf}");
                }
                break;
            case 6:
                Console.WriteLine("Digite o mês: ");
                int mes = int.Parse(Console.ReadLine());
                var advogadosAniversariantes = advogados.Where(a => a.dataDeNascimento.Month == mes);
                var clientesAniversariantes = clientes.Where(c => c.dataDeNascimento.Month == mes);
                foreach(Advogados advogado in advogadosAniversariantes){
                    Console.WriteLine($"Nome: {advogado.nome}");
                    Console.WriteLine($"CPF: {advogado.cpf}");
                }
                foreach(Cliente cliente in clientesAniversariantes){
                    Console.WriteLine($"Nome: {cliente.nome}");
                    Console.WriteLine($"CPF: {cliente.cpf}");
                }
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }       
    }
}