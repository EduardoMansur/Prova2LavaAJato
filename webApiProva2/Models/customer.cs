using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace webApiProva2.Models
{
    public class Customer
    {
        [Key]
        public int idCustomer { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
    }
}