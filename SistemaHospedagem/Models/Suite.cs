using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHospedagem.Models
{
    public class Suite()
    {
        public Suite(int capacidade, decimal valordiaria) : this()
        {
            TipoSuite = "Padrão";
            Capacidade = capacidade;
            ValorDiaria = valordiaria;
        }


        public string TipoSuite { get; set; }

        public int Capacidade { get; set; }

        public decimal ValorDiaria { get; set; }
    }
}