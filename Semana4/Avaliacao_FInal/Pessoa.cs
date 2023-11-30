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
    public string Nome{get; set;}
    public string DataDeNascimento{get; set;}
    public string Cpf{get; set;}
    private bool validaCPF(string cpf){
        if(cpf.Length != 11){
            return false;
        }
        else{
            return true;
        }
    }
}