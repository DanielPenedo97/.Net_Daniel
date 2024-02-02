namespace Techmed.Model;
using Microsoft.EntityFrameworkCore;

/*Atividade
Utilizar o Entity Framework, com os conceitos de DbContext e DbSet para o sistema abaixo:
- Cada médico tem um código, um nome, uma especialidade e um salário.
- Cada paciente tem um CPF, um nome, um endereço e um telefone.
- Cada consulta tem um número, uma data, uma hora, um valor, um médico e um paciente.
- Cada exame tem um código, um nome, um tipo e um preço.
- Cada consulta pode solicitar vários exames, e cada exame pode ser solicitado por várias
consultas.
- O valor de uma consulta é calculado pela soma dos preços dos exames solicitados.*/

public class TechmedContext : DbContext {
    public TechmedContext() {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }
    public DbSet<Paciente> Pacientes { get; set; }
    public DbSet<Medico> Medicos { get; set; }

    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        base.OnConfiguring(optionsBuilder);
        var stringConexao = "Server = localhost; Database = techmed; Uid = dotnet; Pwd = tic2023";
        var serverVersion = ServerVersion.AutoDetect(stringConexao);
        optionsBuilder.UseMySql (stringConexao, serverVersion);
    }   
}

public abstract class Pessoa {
    public int Id { get; set; }
    public required string Nome { get; set; }
    public required string Cpf { get; set; }
}

public class Paciente : Pessoa {
    public string? Telefone { get; set; }
    public string? Endereco { get; set; }
}

public class Medico : Pessoa {
    public required string Crm { get; set; }
    public string? Especialidade { get; set; }
    public decimal Salario { get; set; }
}
/*
public class Consulta {
    public int Numero { get; set; }
    public DateTime Data { get; set; }
    public DateTime Hora { get; set; }
    public decimal Valor { get; set; }
    public Medico Medico { get; set; }
    public Paciente Paciente { get; set; }
    public List<Exame> Exames { get; set; }
}

public class Exame {
    public int Codigo { get; set; }
    public string Nome { get; set; }
    public string Tipo { get; set; }
    public decimal Preco { get; set; }
    public List<Consulta> Consultas { get; set; }
}*/
