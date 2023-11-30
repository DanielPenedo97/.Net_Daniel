#region 
using System;

abstract class Pessoa {
    protected string nome;
    protected string dataDeNascimento;
    protected string cpf;

    public Pessoa(string nome, string dataDeNascimento, string cpf){
        this.nome = nome;
        this.dataDeNascimento = dataDeNascimento;
        this.cpf = cpf;
    }

    public string Nome{
        get{
            return nome;
        }
        set{
            nome = value;
        }
    }

    public string DataDeNascimento{
        get{
            return dataDeNascimento;
        }
        set{
            dataDeNascimento = value;
        }
    }

    public string Cpf{
        get{
            return cpf;
        }
        set{
            cpf = value;
        }
    }
}
class Advogados : Pessoa{
    public string cna;
    public string especialidade;
    public string Cna{
        get{
            return cna;
        }
        set{
            cna = value;
        }
    }
    public string Especialidade{
        get{
            return especialidade;
        }
        set{
            especialidade = value;
        }
    }
    public Advogados(string nome, string cna, string especialidade, string dataDeNascimento) : base(nome, dataDeNascimento){
        this.nome = nome;
        this.cna = cna;
        this.especialidade = especialidade;
        this.dataDeNascimento = dataDeNascimento;
    }
    public void imprime(){
        Console.WriteLine("Nome: {0}", this.nome);
        Console.WriteLine("cna: {0}", this.cna);
        Console.WriteLine("Especialidade: {0}", this.especialidade);
        Console.WriteLine("Data de Nascimento: {0}", this.dataDeNascimento);
    }
}

class Cliente : Pessoa {
    public string estadoCivil;

    public string EstadoCivil{
        get{
            return estadoCivil;
        }
        set{
            estadoCivil = value;
        }
    }
    public Cliente(string nome, string cpf, string estadoCivil, string dataDeNascimento){
        this.nome = nome;
        this.cpf = cpf;
        this.estadoCivil = estadoCivil;
        this.dataDeNascimento
    }
    public void imprime(){
        Console.WriteLine("Nome: {0}", this.nome);
        Console.WriteLine("cpf: {0}", this.cpf);
        Console.WriteLine("Endereço: {0}", this.estadoCivil);
    }
}

#endregion