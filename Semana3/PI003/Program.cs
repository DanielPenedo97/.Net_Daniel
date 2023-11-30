using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    // Definição da tupla para representar um produto
    public record Produto(int Codigo, string Nome, int Quantidade, decimal PrecoUnitario);

    // Lista de produtos em estoque
    static List<Produto> estoque = new List<Produto>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Cadastrar Produto");
            Console.WriteLine("2. Consultar Produto por Código");
            Console.WriteLine("3. Atualizar Estoque");
            Console.WriteLine("4. Gerar Relatórios");
            Console.WriteLine("5. Sair");

            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    CadastrarProduto();
                    break;

                case "2":
                    ConsultarProdutoPorCodigo();
                    break;

                case "3":
                    AtualizarEstoque();
                    break;

                case "4":
                    GerarRelatorios();
                    break;

                case "5":
                    Console.WriteLine("Saindo do programa. Até mais!");
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void CadastrarProduto()
    {
        try
        {
            Console.Write("Código do produto: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Nome do produto: ");
            string nome = Console.ReadLine();

            Console.Write("Quantidade em estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.Write("Preço unitário: ");
            decimal preco = decimal.Parse(Console.ReadLine());

            Produto novoProduto = new Produto(codigo, nome, quantidade, preco);
            estoque.Add(novoProduto);

            Console.WriteLine("Produto cadastrado com sucesso!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Entrada inválida. Certifique-se de inserir valores numéricos corretos.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }

    static void ConsultarProdutoPorCodigo()
    {
        try
        {
            Console.Write("Informe o código do produto: ");
            int codigo = int.Parse(Console.ReadLine());

            var produto = estoque.FirstOrDefault(p => p.Codigo == codigo);

            if (produto != null)
            {
                Console.WriteLine($"Produto encontrado: {produto}");
            }
            else
            {
                throw new ProdutoNaoEncontradoException("Produto não encontrado.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Entrada inválida. Certifique-se de inserir um valor numérico correto.");
        }
        catch (ProdutoNaoEncontradoException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }

    static void AtualizarEstoque()
{
    try
    {
        Console.Write("Informe o código do produto: ");
        int codigo = int.Parse(Console.ReadLine());

        var produto = estoque.FirstOrDefault(p => p.Codigo == codigo);

        if (produto != null)
        {
            Console.Write("Informe a quantidade a ser adicionada (positiva) ou removida (negativa): ");
            int quantidade = int.Parse(Console.ReadLine());

            if (produto.Quantidade + quantidade < 0)
            {
                throw new EstoqueInsuficienteException("Quantidade insuficiente em estoque para realizar a operação.");
            }

            produto = produto with { Quantidade = produto.Quantidade + quantidade };
            Console.WriteLine($"Estoque atualizado. Novo estoque: {produto.Quantidade}");
        }
        else
        {
            throw new ProdutoNaoEncontradoException("Produto não encontrado.");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Erro: Entrada inválida. Certifique-se de inserir valores numéricos corretos.");
    }
    catch (ProdutoNaoEncontradoException ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
    }
    catch (EstoqueInsuficienteException ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro inesperado: {ex.Message}");
    }
}


    static void GerarRelatorios()
    {
        try
        {
            Console.Write("Informe o limite de quantidade para o relatório 1: ");
            int limiteQuantidade = int.Parse(Console.ReadLine());

            var relatorio1 = estoque.Where(p => p.Quantidade < limiteQuantidade);
            ImprimirRelatorio("Produtos com quantidade em estoque abaixo do limite:", relatorio1);

            Console.Write("Informe o valor mínimo para o relatório 2: ");
            decimal minimo = decimal.Parse(Console.ReadLine());

            Console.Write("Informe o valor máximo para o relatório 2: ");
            decimal maximo = decimal.Parse(Console.ReadLine());

            var relatorio2 = estoque.Where(p => p.PrecoUnitario >= minimo && p.PrecoUnitario <= maximo);
            ImprimirRelatorio("Produtos com valor entre mínimo e máximo:", relatorio2);

            var relatorio3 = estoque.Select(p => (p.Nome, p.Quantidade * p.PrecoUnitario));
            ImprimirRelatorio("Valor total do estoque e valor total de cada produto:", relatorio3);
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Entrada inválida. Certifique-se de inserir valores numéricos corretos.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }

    static void ImprimirRelatorio<T>(string titulo, IEnumerable<T> dados)
    {
        Console.WriteLine(titulo);
        foreach (var item in dados)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
}

// Exceção personalizada para produtos não encontrados
class ProdutoNaoEncontradoException : Exception
{
    public ProdutoNaoEncontradoException(string mensagem) : base(mensagem) { }
}

// Exceção personalizada para estoque insuficiente
class EstoqueInsuficienteException : Exception
{
    public EstoqueInsuficienteException(string mensagem) : base(mensagem) { }
}
