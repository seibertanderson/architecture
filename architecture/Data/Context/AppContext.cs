using Data.EntityConfig;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class AppContext : DbContext
    {
        public AppContext() : base("name=NomeBanco")
        {
            this.Configuration.LazyLoadingEnabled = true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //REMOVE CONVENÇÃO DE NOME EM PLURAL NA BASE DE DADOS (ENTITY FRAMEWORK DOESN'T SPEEK PORTUGUESE ;] )
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //CONFIGURAÇÕES PADRÕES PARA PROPRIEDADES STRING -> VARCHAR(255)
            modelBuilder.Properties<string>().Configure(el => el.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(el => el.HasMaxLength(255));

            modelBuilder.Configurations.Add(new ProdutoConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
