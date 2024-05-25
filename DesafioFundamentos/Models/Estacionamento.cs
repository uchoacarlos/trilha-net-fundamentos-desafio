// Neste programa, as horas de permanência dos veículos no estacionamento são inseridas manualmente pelo usuário durante a remoção do veículo.
namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {


        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            Console.WriteLine($"Veículo com placa {placa} adicionado.");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = precoInicial + (precoPorHora * horas);
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}


// Neste programa otimizado, o horário de entrada dos veículos é registrado automaticamente no momento em que são adicionados ao estacionamento.
// Isso elimina a necessidade de inserção manual das horas de permanência e aumenta a precisão do cálculo do tempo de permanência e do valor total a ser pago.

/* using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<(string placa, DateTime horarioEntrada)> veiculos = new List<(string, DateTime)>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            DateTime horarioEntrada = DateTime.Now; // Obtém o horário atual
            veiculos.Add((placa, horarioEntrada));
            Console.WriteLine($"Veículo com placa {placa} adicionado às {horarioEntrada}");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            var veiculo = veiculos.FirstOrDefault(v => v.placa.ToUpper() == placa.ToUpper());
            if (veiculo != default((string, DateTime))) // Verifica se o veículo foi encontrado
            {
                DateTime horarioSaida = DateTime.Now; // Obtém o horário atual
                TimeSpan tempoEstacionado = horarioSaida - veiculo.horarioEntrada; // Calcula o tempo de permanência
                int horas = (int)Math.Ceiling(tempoEstacionado.TotalHours); // Arredonda para cima o número de horas
                decimal valorTotal = precoInicial + (precoPorHora * horas);
                
                veiculos.Remove(veiculo);
                Console.WriteLine($"O veículo {placa} foi removido às {horarioSaida} e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine($"{veiculo.placa} - Entrada: {veiculo.horarioEntrada}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
} */

