#region 

using System;
using System.Net.WebSockets;

class Veiculo{
        public string modelo;
        public string cor;
        public int ano;
        public string IdadeVeiculo{
            get{
                int idade = DateTime.Now.Year - ano;
                return idade.ToString();
            }
        }
        public Veiculo(string marca, string modelo, string cor, int ano, double preco){
            this.modelo = modelo;
            this.cor = cor;
            this.ano = ano;
        }
        public void imprime(){
            Console.WriteLine("Modelo: {0}", this.modelo);
            Console.WriteLine("Cor: {0}", this.cor);
            Console.WriteLine("Ano: {0}", this.ano);
            Console.WriteLine("Idade do veículo: {0}", this.IdadeVeiculo);
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
        static void Main(){
            Carro c = new Carro("Fiat", "Uno", "Vermelho", 2010, 15000);
            c.imprime();
        }
    }

#endregion

#region 



#endregion