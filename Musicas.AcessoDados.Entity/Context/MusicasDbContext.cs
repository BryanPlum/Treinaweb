using Musicas.AcessoDados.Entity.TypeConfiguration;
using Musicas.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musicas.AcessoDados.Entity.Context
{
     public class MusicasDbContext : DbContext
    {
        public DbSet <Album> Albums { get; set; }

        public MusicasDbContext()
        {
            Configuration.LazyLoadingEnabled = false;
            //Carregamento detalhado, o que gera perda de performance em uma iteração, por exemplo.

            Configuration.ProxyCreationEnabled = false;
        }

        //Avisando a classe que temos configs personalizadas na criação das tabelas. caso não seja feito, prevalecem as configs padrão do EntityFW

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AlbumTypeConfiguration());
            modelBuilder.Configurations.Add(new MusicaTypeConfiguration());

        }
    }
}
