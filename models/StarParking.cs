using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarParking.models
{
    public class Estacionamento
    {
        decimal valorFixo = 0;
        decimal valorHora = 0;

        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal valorFixo, decimal valorHora)
        {
            this.valorFixo = valorFixo;
            this.valorHora = valorHora;

        }
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo");
            veiculos.Add(Console.ReadLine());
            Console.WriteLine("Veiculo adicionado com sucesso!");

    }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veiculo");
            string placa = Console.ReadLine();

            if(veiculos.Any(x => x.ToUpper() == placa.ToUpper())) {

                Console.WriteLine("Digite a quantidade de horas");
                decimal quantidadeHoras = Convert.ToDecimal(Console.ReadLine());

                decimal valorTotal = valorFixo + valorHora * quantidadeHoras;

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }

            else {
                Console.WriteLine("Esse veículo não está estacionado aqui. Verifique se digitou a placa corretamente");


                    }

        }

        public void ListarVeiculos()
        {
            foreach(string i in veiculos){

                Console.WriteLine(i);

            }
        }
    }

    
}
