namespace _Advogados;
using _Pessoa;
class Advogados : Pessoa{
    public string cna;
    public string Cna{get; set;}
    public Advogados(string nome, DateTime dataDeNascimento, string cpf, string cna) : base(nome, dataDeNascimento, cpf){
        this.nome = nome;
        this.dataDeNascimento = dataDeNascimento;
        this.cpf = cpf;
        this.cna = cna;
    }
    public bool AddAdvogado(List<Advogados> advogados){
        if (advogados.Exists(a => a.cpf == this.cpf || a.cna == this.cna))
            return false;

        advogados.Add(this);
        return true;
    }
}
