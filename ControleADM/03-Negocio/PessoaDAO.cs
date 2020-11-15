using ControleADM.DataAccess;
using ControleADM.Models;

namespace ControleADM.Negocio
{
    public class PessoaDAO : IAcessoDadosObject<Pessoa>
    {
        private DALHelper dal = new DALHelper();

        public bool exclua(Pessoa pessoa)
        {
            return true;
        }
        public bool insira(Pessoa pessoa)
        {
            return true;
        }
        public bool altere(Pessoa pessoa)
        {
            return true;
        }
        public long consulte(Pessoa pessoa)
        {
            return 0;
        }

    }
}
