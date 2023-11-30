using System;
using System.Globalization;
using _Pessoa;
using _Advogados;
using _Cliente;

CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("pt-BR");

#region Herança

class Principal{
    static void Main(){
        /*Cliente cliente = new Cliente("Valber", "10/10/1990", "123456789-00", "Solteiro", "Programador");
        Advogados advogado = new Advogados("Helder", "10/10/1990", "123456789-00", "123456789-00");
        Console.WriteLine(cliente.Nome);
        Console.WriteLine(advogado.Nome);*/

        List<Advogados> advogados = new List<Advogados>();

        List<Cliente> clientes = new List<Cliente>();

        Advogados advogado1 = new Advogados("Helder", new DateTime(1, 1, 2001), "123456789-00", "123456789-00");
        advogados.Add(advogado1);
        Advogados advogado2 = new Advogados("Helder", new DateTime(3, 5, 1998), "123456789-00", "123456789-00");
        advogados.Add(advogado2);

        Cliente cliente1 = new Cliente("Valber", new DateTime(3, 5, 1998), "123486789-00", "Solteiro", "Programador");
        clientes.Add(cliente1);
        Cliente cliente2 = new Cliente("Daniel", new DateTime(3, 5, 1998), "123436789-00", "Solteiro", "Programador");
        clientes.Add(cliente2);

        foreach(Advogados advogado in advogados){
            advogado.imprime();
        }

        foreach(Cliente cliente in clientes){
            cliente.imprime();
        }




        
    }
}
#endregion