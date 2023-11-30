#region 

using System;

    class Veiculo{
        public string modelo;
        public string cor;
        public int ano;
        public Veiculo(string marca, string modelo, string cor, int ano, double preco){
            this.modelo = modelo;
            this.cor = cor;
            this.ano = ano;
        }
        public void imprime(){
            Console.WriteLine("Modelo: {0}", this.modelo);
            Console.WriteLine("Cor: {0}", this.cor);
            Console.WriteLine("Ano: {0}", this.ano);
        }
    }

    class Carro : Veiculo{
        public double preco;
        public Carro(string marca, string modelo, string cor, int ano, double preco) : base(marca, modelo, cor, ano, preco){
            this.preco = preco;
        }
        public void imprime(){
            base.imprime();
            Console.WriteLine("Preço: {0}", this.preco);
        }
    }

#endregion