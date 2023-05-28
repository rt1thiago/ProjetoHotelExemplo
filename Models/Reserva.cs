using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoHotelExemplo.Models;

namespace ProjetoHotelExemplo.Models
{
    public class Reserva
    {
        List<Pessoa> Hospedes {get;set;}
        Suite suite {get;set;}
        int DiasReservados {get; set;}

        public Reserva()
        {

        }
 
        public void CadastrarHospedes(List<Pessoa> hospedesinterface)
        {
            int CapacidadeSuite = 10;
            int QuantidadeHospesdes = hospedesinterface.Count();

            if (QuantidadeHospesdes > CapacidadeSuite)
            {
                throw new ArgumentException("Não será possível cadastrar os Hospedes");
            }
            else
            {
                Hospedes=hospedesinterface;
                Console.Write("Cadastrado com Sucesso");
            }
        }

        public void CadastrarDias(int DiasReserv)
        {
            DiasReservados = DiasReserv;
        }
        
        public void CadastrarSuite(Suite Quarto)
        {
            suite = Quarto;
            Console.WriteLine($"Suíte Cadastrada com Sucesso." );
        }

        public int ObterQuantidadeHospedes()
        {
            int quantidade = Hospedes.Count();
            return 0;
        }

        public decimal CalculoValorDiaria()
        {
           
            decimal valordiaria = 10;
            if (DiasReservados > 10)
            {
                valordiaria=valordiaria*0.9M;
            }
            return 0;
        }


    }

}