using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    // Defina uma classe para representar uma tarefa
    class Tarefa
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataVencimento { get; set; }
        public bool Concluida { get; set; }
    }

    static List<Tarefa> listaDeTarefas = new List<Tarefa>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n===== Sistema de Gerenciamento de Tarefas =====");
            Console.WriteLine("1. Criar Tarefa");
            Console.WriteLine("2. Listar Tarefas");
            Console.WriteLine("3. Marcar Tarefa como Concluída");
            Console.WriteLine("4. Listar Tarefas Pendentes");
            Console.WriteLine("5. Listar Tarefas Concluídas");
            Console.WriteLine("6. Excluir Tarefa");
            Console.WriteLine("7. Pesquisar Tarefas por Palavra-Chave");
            Console.WriteLine("8. Exibir Estatísticas");
            Console.WriteLine("9. Sair");

            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    CriarTarefa();
                    break;
                case "2":
                    ListarTarefas();
                    break;
                case "3":
                    MarcarTarefaConcluida();
                    break;
                case "4":
                    ListarTarefasPendentes();
                    break;
                case "5":
                    ListarTarefasConcluidas();
                    break;
                case "6":
                    ExcluirTarefa();
                    break;
                case "7":
                    PesquisarPorPalavraChave();
                    break;
                case "8":
                    ExibirEstatisticas();
                    break;
                case "9":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void CriarTarefa()
    {
        Console.Write("Digite o título da tarefa: ");
        string titulo = Console.ReadLine();

        Console.Write("Digite a descrição da tarefa: ");
        string descricao = Console.ReadLine();

        Console.Write("Digite a data de vencimento da tarefa (formato DD/MM/AAAA): ");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime dataVencimento))
        {
            Tarefa novaTarefa = new Tarefa
            {
                Titulo = titulo,
                Descricao = descricao,
                DataVencimento = dataVencimento,
                Concluida = false
            };

            listaDeTarefas.Add(novaTarefa);
            Console.WriteLine("Tarefa criada com sucesso!");
        }
        else
        {
            Console.WriteLine("Formato de data inválido. Tarefa não criada.");
        }
    }

    static void ListarTarefas()
    {
        Console.WriteLine("\n===== Lista de Tarefas =====");
        foreach (var tarefa in listaDeTarefas)
        {
            Console.WriteLine($"Título: {tarefa.Titulo}\nDescrição: {tarefa.Descricao}\nData de Vencimento: {tarefa.DataVencimento.ToShortDateString()}\nConcluída: {tarefa.Concluida}\n");
        }
    }

    static void MarcarTarefaConcluida()
    {
        ListarTarefas();
        Console.Write("Digite o número da tarefa que deseja marcar como concluída: ");
        if (int.TryParse(Console.ReadLine(), out int numeroTarefa) && numeroTarefa >= 1 && numeroTarefa <= listaDeTarefas.Count)
        {
            listaDeTarefas[numeroTarefa - 1].Concluida = true;
            Console.WriteLine("Tarefa marcada como concluída!");
        }
        else
        {
            Console.WriteLine("Número de tarefa inválido. Operação cancelada.");
        }
    }

    static void ListarTarefasPendentes()
    {
        var tarefasPendentes = listaDeTarefas.Where(t => !t.Concluida).ToList();
        if (tarefasPendentes.Any())
        {
            Console.WriteLine("\n===== Tarefas Pendentes =====");
            foreach (var tarefa in tarefasPendentes)
            {
                Console.WriteLine($"Título: {tarefa.Titulo}\nDescrição: {tarefa.Descricao}\nData de Vencimento: {tarefa.DataVencimento.ToShortDateString()}\n");
            }
        }
        else
        {
            Console.WriteLine("Não há tarefas pendentes.");
        }
    }

    static void ListarTarefasConcluidas()
    {
        var tarefasConcluidas = listaDeTarefas.Where(t => t.Concluida).ToList();
        if (tarefasConcluidas.Any())
        {
            Console.WriteLine("\n===== Tarefas Concluídas =====");
            foreach (var tarefa in tarefasConcluidas)
            {
                Console.WriteLine($"Título: {tarefa.Titulo}\nDescrição: {tarefa.Descricao}\nData de Vencimento: {tarefa.DataVencimento.ToShortDateString()}\n");
            }
        }
        else
        {
            Console.WriteLine("Não há tarefas concluídas.");
        }
    }

    static void ExcluirTarefa()
    {
        ListarTarefas();
        Console.Write("Digite o número da tarefa que deseja excluir: ");
        if (int.TryParse(Console.ReadLine(), out int numeroTarefa) && numeroTarefa >= 1 && numeroTarefa <= listaDeTarefas.Count)
        {
            listaDeTarefas.RemoveAt(numeroTarefa - 1);
            Console.WriteLine("Tarefa excluída com sucesso!");
        }
        else
        {
            Console.WriteLine("Número de tarefa inválido. Operação cancelada.");
        }
    }

    static void PesquisarPorPalavraChave()
    {
        Console.Write("Digite a palavra-chave para a pesquisa: ");
        string palavraChave = Console.ReadLine().ToLower();

        var tarefasEncontradas = listaDeTarefas.Where(t => t.Titulo.ToLower().Contains(palavraChave) || t.Descricao.ToLower().Contains(palavraChave)).ToList();

        if (tarefasEncontradas.Any())
        {
            Console.WriteLine("\n===== Tarefas Encontradas =====");
            foreach (var tarefa in tarefasEncontradas)
            {
                Console.WriteLine($"Título: {tarefa.Titulo}\nDescrição: {tarefa.Descricao}\nData de Vencimento: {tarefa.DataVencimento.ToShortDateString()}\n");
            }
        }
        else
        {
            Console.WriteLine("Nenhuma tarefa encontrada com a palavra-chave fornecida.");
        }
    }

    static void ExibirEstatisticas()
    {
        int totalTarefas = listaDeTarefas.Count;
        int tarefasConcluidas = listaDeTarefas.Count(t => t.Concluida);
        int tarefasPendentes = totalTarefas - tarefasConcluidas;

        DateTime tarefaMaisAntiga = listaDeTarefas.Min(t => t.DataVencimento);
        DateTime tarefaMaisRecente = listaDeTarefas.Max(t => t.DataVencimento);

        Console.WriteLine($"\n===== Estatísticas =====");
        Console.WriteLine($"Total de Tarefas: {totalTarefas}");
        Console.WriteLine($"Tarefas Concluídas: {tarefasConcluidas}");
        Console.WriteLine($"Tarefas Pendentes: {tarefasPendentes}");
        Console.WriteLine($"Tarefa mais antiga: {tarefaMaisAntiga.ToShortDateString()}");
        Console.WriteLine($"Tarefa mais recente: {tarefaMaisRecente.ToShortDateString()}");
    }
}
