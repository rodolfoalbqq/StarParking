using StarParking;
using StarParking.models;


decimal valorFixo = 0;
decimal valorHora = 0;

Console.WriteLine("Seja bem vindo ao Star Parking!\n" +
  "Digite o valor do estacionamento");

valorFixo = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Agora digite o preço por hora:");
valorHora = Convert.ToDecimal(Console.ReadLine());


Estacionamento es = new Estacionamento(valorFixo, valorHora);

string opcao = string.Empty;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
