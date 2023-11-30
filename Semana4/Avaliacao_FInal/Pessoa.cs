namespace _Pessoa;
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