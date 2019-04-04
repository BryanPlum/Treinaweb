using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musicas.Dominio
{
    public class Musica
    {
        public long Id { get; set; }
        public string Nome { get; set; }

        public virtual Album Album { get; set; }//Vincular a musica ao Album
        public int IdAlbum { get; set; }//Vincular a musica ao Album
    }
}
