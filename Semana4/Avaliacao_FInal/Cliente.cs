namespace _Cliente;

using _Pessoa;

class Cliente : Pessoa {
    public string estadoCivil;
    public string profissao;
    public string EstadoCivil{get; set;}
    public string Profissao{get; set;}  

    public Cliente (string nome, DateTime dataDeNascimento, string cpf, string estadoCivil, string profissao) : base(nome, dataDeNascimento, cpf){
        this.nome = nome;
        this.dataDeNascimento = dataDeNascimento;
        this.cpf = cpf;
        this.estadoCivil = estadoCivil;
        this.profissao = profissao; 
    }
} 