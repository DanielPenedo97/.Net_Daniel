namespace _Pessoa;
abstract class Pessoa {
    public string nome;
    public DateTime dataDeNascimento;
    public string cpf;
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
    private bool validaCPF(string cpf){
        if(cpf.Length != 11){
            return false;
        }
        else{
            return true;
        }
    }
    
}