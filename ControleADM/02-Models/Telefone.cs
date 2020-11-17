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
