using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_desafio_dio_hospedagem_hotel.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        public Pessoa()
        {
            
        }
        private string _nome;
        public string Nome
        {
            get
            {
                return _nome.ToUpper();
            }
            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            }
        }
        private string _sobrenome;
        public string Sobrenome
        { 
            get {
                return _sobrenome.ToUpper();
            }
            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _sobrenome = value;
            }
        }


    }
}