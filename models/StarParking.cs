using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarParking.models
{
    public class Estacionamento(decimal valorFixo, decimal valorHora)
    {
        decimal valorFixo = 0;
        decimal valorHora = 0;

        private List<string> veiculos = new List<string>();
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo");
            veiculos.Add(Console.ReadLine());
            Console.WriteLine("Veiculo adicionado");

        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veiculo para remover.");


        }

        public void ListarVeiculos()
        {
            foreach(string i in veiculos){

                Console.WriteLine(i);

            }
        }
    }

    
}
