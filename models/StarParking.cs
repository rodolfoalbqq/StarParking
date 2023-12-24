using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarParking.models
{
    class Veiculo
    {
        public string Placa { get; set; }
        public DateTime Entrada { get; set; }
    }

    public class Estacionamento
    {
        private List<Veiculo> veiculos;

        public Estacionamento()
        {
            veiculos = new List<Veiculo>();
        }

        public void AdicionarVeiculo(string placa)
        {
            Veiculo novoVeiculo = new Veiculo
            {
                Placa = placa,
                Entrada = DateTime.Now
            };

            veiculos.Add(novoVeiculo);
            Console.WriteLine($"Veículo {placa} adicionado ao estacionamento.");

        }

        public void RemoverVeiculo(string placa)
        {
            Veiculo veiculo = veiculos.Find(v => v.Placa == placa);

            if (veiculo != null) 
            {
                DateTime saida = DateTime.Now;
                TimeSpan duracao = saida - veiculo.Entrada;
                double valorCobrado = CalcularValorCobrado(duracao);

                Console.WriteLine($"Veículo {placa} removido do estacionamento.");
                Console.WriteLine($"Tempo estacionado: {duracao.TotalHours} minutos.");
                Console.WriteLine($"Valor cobrado: R$ {valorCobrado:F2}");

                veiculos.Remove(veiculo);
            }

            else {
                Console.WriteLine($"Veículo {placa} não encontrado no estacionamento.");


                  }

        }

        public void ListarVeiculos()
        {
            Console.WriteLine("Veículos estacionados:");
            foreach (Veiculo veiculo in veiculos)
            {
                Console.WriteLine($"Placa: {veiculo.Placa}, Entrada: {veiculo.Entrada}");
            }
        }

        private double CalcularValorCobrado(TimeSpan duracao)
        {
            // Exemplo de cálculo simples. Você pode ajustar conforme necessário.
            const double taxaHora = 5.0;
            const int precoInicial = 5;
            
            return duracao.TotalHours * taxaHora + precoInicial;
        }
    }

    
}
