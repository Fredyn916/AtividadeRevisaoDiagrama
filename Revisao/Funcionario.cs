using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    public class Funcionario : Pessoa
    {
        public int Matricula { get; set; }
        public string PlacaVeiculo { get; set; }

        public bool VerificarVeiculo(Automovel automovel)
        {

        }
    }
}
