using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFundamentos.Services
{
    internal class EstacionamentoServices
    {
        public static bool IsVehicleOnParklot(string placa, List<string> veiculos)
        {
            return veiculos.Any(x => x.ToUpper() == placa.ToUpper());
        }

        internal static decimal TotalParkCost(decimal precoInicial, decimal precoPorHora)
        {
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
            
            int horas = Int32.Parse(Console.ReadLine());
            decimal valorTotal = precoInicial + (precoPorHora * horas);
            return valorTotal;

        }
    }
}
