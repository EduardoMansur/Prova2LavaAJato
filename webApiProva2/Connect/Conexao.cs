using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace webApiProva2.Connect
{
    public class Conexao : DbContext
    {
        public Conexao() : base("name=MinhaConexao"){

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        }

        public System.Data.Entity.DbSet<webApiProva2.Models.Material> Material { get; set; }

        public System.Data.Entity.DbSet<webApiProva2.Models.Customer> Customer { get; set; }

        public System.Data.Entity.DbSet<webApiProva2.Models.Servico> Servico { get; set; }

        public System.Data.Entity.DbSet<webApiProva2.Models.Gasto> Gasto { get; set; }
    }
}