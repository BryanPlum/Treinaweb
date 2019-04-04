using Musicas.Dominio;
using RepositoriosComum.Entity;
using Musicas.AcessoDados.Entity;
using Musicas.AcessoDados.Entity.Context;

namespace Repositorios.Entity
{
    public class AlbumsRepositorio : RepositorioGenericoEntity<Album, int>
    {
        public AlbumsRepositorio(MusicasDbContext contexto)
            : base(contexto)
        {

        }
    }
}
