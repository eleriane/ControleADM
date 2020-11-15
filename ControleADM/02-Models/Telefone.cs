using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleADM.Models
{
    public class Telefone
    {
        public int id { get; set; }
        public int numero { get; set; }
        public int ddd { get; set; }
        public TipoTelefone tipoTelefone { get; set; }
    }
}
