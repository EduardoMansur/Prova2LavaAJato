using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace webApiProva2.Models
{
    public class Gasto
    {

        [Key]
        public int idGasto { get; set; }
        public double valor { get; set; }
        public int idMaterial { get; set; }

    }
}