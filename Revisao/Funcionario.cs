using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    public class Funcionario : Pessoa
    {
        private int Matricula { get; set; }
        private string PlacaVeiculo { get; set; }

        public Funcionario(string plavaveiculo)
        {
            PlacaVeiculo = plavaveiculo;
        }

        public int MatriculaFuncionario()
        {
            int matricula = Matricula;
            return matricula;
        }

        public bool VerificarVeiculo(Automovel automovel)
        {
            if(PlacaVeiculo.Length == 7)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
