using System.Text;
using ProjetoHotelExemplo.Models;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa a1 = new Pessoa(nome:"Thiago",sobrenome:"Ferreira");
Pessoa a2 = new Pessoa(nome:"Alana",sobrenome:"Ferreira");
Pessoa a3 = new Pessoa(nome:"Iron",sobrenome:"Ferreira");

hospedes.Add(a1);
hospedes.Add(a2);
hospedes.Add(a3);

Suite suite = new Suite(tipo:"Apartamento",capacidade:4,valordiaria:120.2M);
Reserva reserva = new Reserva();

reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);
reserva.CadastrarDias(20);


Console.WriteLine($"Quantidade de Hospedes:{reserva.ObterQuantidadeHospedes}");
Console.WriteLine($"Valor da Diária:{reserva.CalculoValorDiaria}");
