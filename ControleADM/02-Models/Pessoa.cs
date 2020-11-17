namespace ControleADM.Models
{
    public class Pessoa
    {
        public int id { get; set; }
        public string nome { get; set; }
        public long cpf { get; set; }
        public Endereco endereco { get; set; }
        public Telefone telefone { get; set; }
    }
}
