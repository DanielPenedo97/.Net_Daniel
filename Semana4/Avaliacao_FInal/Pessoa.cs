namespace _Pessoa;
abstract class Pessoa {
    protected string nome;
    protected DateTime dataDeNascimento;
    protected string? cpf;
    public Pessoa(string nome, DateTime dataDeNascimento, string cpf){
        this.nome = nome;
        this.dataDeNascimento = dataDeNascimento;
        if(validaCPF(cpf)){
            this.cpf = cpf;
        }
        else{
            throw new Exception("CPF inválido");
        }
    }
    public string Nome{get; set;}
    public DateTime DataDeNascimento{get; set;}
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