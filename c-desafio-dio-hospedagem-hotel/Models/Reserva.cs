using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_desafio_dio_hospedagem_hotel.Models
{
    public class Reserva
    {
        List<Pessoa> Hospedes = new List<Pessoa>();
        Suite suite = new Suite("suite1", 5, 400.0M);
        public int DiasReservados { get; set; }
        public void CadastrarHospedes(List<Pessoa> Hospedes)
        {
            if (Hospedes.Count < suite.Capacidade)
            {
                Console.WriteLine("Digite seu nome completo:");
                Hospedes.Add(new Pessoa());
            }
        }
        public void CadastrarSuite(Suite suite)
        {
            suite = new Suite();
        }
        public double CalcularValorDiaria(int dias)
    {    
        Console.WriteLine("Quantas diarias?");
         decimal ValorTotal = 0;
         dias = int.Parse(Console.ReadLine());
        if (dias > 0)
        {
            ValorTotal = suite.ValorDiaria * Convert.ToDecimal(dias);
            Console.WriteLine($" Para {dias} diarias, no total irá dar valor total de: {ValorTotal}");
        }else {
            Console.WriteLine("Não foi possivel calcular valor total das diarias, por favor tente novamente e de preferencia escreva um numero valido.");
        }
        return dias;
    }
    public void ObterQuantidadeHospedes()
    {
        Console.WriteLine(Hospedes.Count());
    }
       

    }
}