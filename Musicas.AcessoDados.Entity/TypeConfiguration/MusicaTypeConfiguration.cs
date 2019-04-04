using Musicas.Comum.Entity;
using Musicas.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musicas.AcessoDados.Entity.TypeConfiguration
{
    class MusicaTypeConfiguration : TreinaWebEntityAbstractConfig<Musica>
    {
        protected override void ConfigurarCamposTabela()
        {
            Property(p => p.Id)
                .HasColumnName("MUS_ID")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(p => p.Nome)
                .HasColumnName("MUS_NOME")
                .HasMaxLength(50)
                .IsRequired();

            Property(p => p.IdAlbum)
                .HasColumnName("ALB_ID")
                .IsRequired();
                
        }

        protected override void ConfigurarChaveEst()
        {
            HasKey(pk => pk.Id);
        }

        protected override void ConfigurarChavePrim()
        {
           

            HasRequired(p => p.Album)//Dizemos aqui que todas musicas tem como obrigação um album, e um album tem várias musicas 
                 .WithMany(p => p.Musicas)
                 .HasForeignKey(fk => fk.IdAlbum);
        }

        protected override void ConfigurarNomeTabela()
        {
            throw new NotImplementedException();
        }
    }
}
