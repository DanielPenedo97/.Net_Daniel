using System;
using System.Globalization;
using _Pessoa;
using _Advogados;
using _Cliente;

CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("pt-BR");

#region Herança

Cliente cliente = new Cliente("Valber", "10/10/1990", "123456789-00", "Solteiro", "Programador");
/*Advogados advogado = new Advogados();
advogado.Nome = "Helder";
advogado.Cpf = "123456789-00";
advogado.DataDeNascimento = "10/10/1990";
advogado.Cna = "123456789-00";*/

Console.WriteLine(cliente.Nome);


#endregion