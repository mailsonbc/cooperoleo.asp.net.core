namespace cooperoleo.Models
{
    public class ContatoModel
    {
        public int ContatoId { get; set; }
        public String Nome { get; set; }
        public String Cpf { get; set; }
        public String Telefone { get; set; }
        public CondominioModel Endereco { get; set; }
        public Boolean Ativo { get; set; }
    }
}
