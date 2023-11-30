namespace _Advogados;
using _Pessoa;
class Advogados : Pessoa{
    public string cna;
    public string Cna{
        get{
            return cna;
        }
        set{
            cna = value;
        }
    }
    public Advogados(string nome, string dataDeNascimento, string cpf, string cna) : base(nome, dataDeNascimento, cpf){
        this.nome = nome;
        this.dataDeNascimento = dataDeNascimento;
        this.cpf = cpf;
        this.cna = cna;
    }
    public void imprime(){
        Console.WriteLine("Nome: {0}", this.nome);
        Console.WriteLine("cna: {0}", this.cna);
        Console.WriteLine("Data de Nascimento: {0}", this.dataDeNascimento);
    }
}
