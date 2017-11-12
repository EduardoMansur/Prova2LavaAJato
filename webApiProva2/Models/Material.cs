using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace webApiProva2.Models
{
    public class Material
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public int qtd { get; set; }
    }
}