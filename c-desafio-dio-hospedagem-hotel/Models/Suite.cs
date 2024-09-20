using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_desafio_dio_hospedagem_hotel.Models
{
    public class Suite
    {
        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }
        public Suite()
        {
            
        }
        private string _tipoSuite;
        public string TipoSuite 
        { 
            get
            {
                return _tipoSuite;
            }
            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O tipo suite não pode ser vazio");
                }

                _tipoSuite = value;
            }
        }
        private int _capacidade;
        public int Capacidade
        { 
            get
            {
                return _capacidade;
            }
            set{
                if(value <= 0)
                {
                    throw new ArgumentException("A capacidade não pode ser vazio");
                }

                _capacidade = value;
            } 
        }
        private decimal _valorDiario;
        public decimal ValorDiaria 
        { 
            get
            {
                return _valorDiario;
            } 
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _valorDiario = value;
            }
        }
    }
}