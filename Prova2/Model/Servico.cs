using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova2.Model
{
   public class Servico
    {
        public int idServico { get; set; }

        public int tipoServico { get; set; }
        public string placaVeiculo { get; set; }
        public double preco { get; set; }
        public int idCliente { get; set; }
        public int tipoVeiculo { get; set; }
    }
}
