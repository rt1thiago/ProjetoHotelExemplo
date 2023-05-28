using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoHotelExemplo.Models;

namespace ProjetoHotelExemplo.Models
{
    public class Pessoa
    {
        string Nome {get; set;}
        string SobreNome {get;set;}

        public Pessoa(string nome, string sobrenome)
        {
            Nome=nome;
            SobreNome=sobrenome;
        }
    }
}