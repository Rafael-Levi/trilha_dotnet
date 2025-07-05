using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHospedagem.Models
{
    public class Pessoa
    {   
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string _nome;
        private string _sobrenome;
        public string Nome
        {
            get => _nome;

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Nome não pode ser vazio");
                }
                _nome = value;
            }
        }
    
        public string Sobrenome
        {
            get => _sobrenome;

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Nome não pode ser vazio");
                }
                _sobrenome = value;
            }

        }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
    }
}