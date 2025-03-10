using DesafioFundamentos.Services;

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

            bool isVehicleOnParklot = EstacionamentoServices.IsVehicleOnParklot(placa, veiculos);

            if (isVehicleOnParklot)
                Console.WriteLine("Já existe um veículo com esta placa no estacionamento");
            else
                veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = Console.ReadLine();

            if (EstacionamentoServices.IsVehicleOnParklot(placa,veiculos))
            {
                decimal valorTotal = EstacionamentoServices.TotalParkCost(precoInicial, precoPorHora);

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach(var veiculo in veiculos)
                    Console.WriteLine(veiculo);
            }   
            else
                Console.WriteLine("Não há veículos estacionados.");
        }
    }
}
