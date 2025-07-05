using System.Text;
using SistemaHospedagem.Models;


Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = [];

Pessoa p1 = new(nome: "Rafael",sobrenome:"Levi");
Pessoa p2 = new(nome: "Miguel",sobrenome:"Dias");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new(capacidade: 2, valordiaria: 110M);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");