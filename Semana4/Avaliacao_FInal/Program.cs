#region 
using System;

class Advogados{
    public string nome;
    public string cna;
    public string especialidade;

    public string dataDeNascimento;

    public string DataDeNascimento{
        get{
            return dataDeNascimento;
        }
        set{
            dataDeNascimento = value;
        }
    }
    
    public string Nome{
        get{
            return nome;
        }
        set{
            nome = value;
        }
    }
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
    public Advogados(string nome, string cna, string especialidade, string dataDeNascimento){
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

class Cliente{
    public string nome;
    public string cpf;
    public string endereco;
    public string Nome{
        get{
            return nome;
        }
        set{
            nome = value;
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
    public string Endereco{
        get{
            return endereco;
        }
        set{
            endereco = value;
        }
    }
    public Cliente(string nome, string cpf, string endereco){
        this.nome = nome;
        this.cpf = cpf;
        this.endereco = endereco;
    }
    public void imprime(){
        Console.WriteLine("Nome: {0}", this.nome);
        Console.WriteLine("cpf: {0}", this.cpf);
        Console.WriteLine("Endereço: {0}", this.endereco);
    }
}

#endregion