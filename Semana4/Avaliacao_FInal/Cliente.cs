namespace _Cliente;

using _Pessoa;

class Cliente : Pessoa {
    public string estadoCivil;

    public string profissao;

    public string EstadoCivil{
        get{
            return estadoCivil;
        }
        set{
            estadoCivil = value;
        }
    }

    public string Profissao{
        get{
            return profissao;
        }
        set{
            profissao = value;
        }
    }
    public Cliente (string nome, string dataDeNascimento, string cpf, string estadoCivil, string profissao) : base(nome, dataDeNascimento, cpf){
        this.nome = nome;
        this.dataDeNascimento = dataDeNascimento;
        this.cpf = cpf;
        this.estadoCivil = estadoCivil;
        this.profissao = profissao; 
    }
    public void imprime(){
        Console.WriteLine("Nome: {0}", this.nome);
        Console.WriteLine("cpf: {0}", this.cpf);
        Console.WriteLine("Endereço: {0}", this.estadoCivil);
    }
} 