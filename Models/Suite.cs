using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoHotelExemplo.Models;

namespace ProjetoHotelExemplo.Models
{
    public class Suite
    {
        string TipoSuite {get; set;}
        int Capacidade {get; set;}
        decimal ValorDiaria {get; set;}

        public Suite (string tipo,int capacidade , decimal valordiaria)
        {
            TipoSuite = tipo;
            Capacidade=capacidade;
            ValorDiaria=valordiaria;
        }
    }

  

}