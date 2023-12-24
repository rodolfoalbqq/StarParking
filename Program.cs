using StarParking;
using StarParking.models;

class Program
{
    static void Main()
    {
        Estacionamento estacionamento = new Estacionamento();

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Cadastrar veículo");
            Console.WriteLine("2. Remover veículo");
            Console.WriteLine("3. Listar veículos");
            Console.WriteLine("4. Encerrar");

            Console.Write("Escolha uma opção (1-4): ");
            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    Console.Write("Digite a placa do veículo: ");
                    string placa = Console.ReadLine();
                    estacionamento.AdicionarVeiculo(placa);
                    break;

                case "2":
                    Console.Write("Digite a placa do veículo a ser removido: ");
                    placa = Console.ReadLine();
                    estacionamento.RemoverVeiculo(placa);
                    break;

                case "3":
                    estacionamento.ListarVeiculos();
                    break;

                case "4":
                    Console.WriteLine("Encerrando o programa. Até logo!");
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

}