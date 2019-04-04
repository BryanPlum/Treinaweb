using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musicas.Comum.Entity
{
    public abstract class TreinaWebEntityAbstractConfig<TEntidade> : EntityTypeConfiguration<TEntidade>

         where TEntidade : class
    {
        public TreinaWebEntityAbstractConfig()
        {
            ConfigurarNomeTabela();
            ConfigurarCamposTabela();
            ConfigurarChavePrim();
            ConfigurarChaveEst();

        }

        protected abstract void ConfigurarChaveEst();


        protected abstract void ConfigurarChavePrim();


        protected abstract void ConfigurarCamposTabela();

        protected abstract void ConfigurarNomeTabela();

    }
}
