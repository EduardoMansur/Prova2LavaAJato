using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace webApiProva2.Models
{
    public class Servico
    {
        [Key]
        public int idServico { get; set; }
        
        public int tipoServico { get; set; }
        public string placaVeiculo { get; set; }
        public float preco { get; set; }
        public int idCliente { get; set; }
        public int tipoVeiculo { get; set; }

    }
}