namespace cooperoleo.Models
{
    public class CondominioModel
    {
        public int CondominioId { get; set; }
        //public ContatoModel Contato { get; set; }
        public String Contato { get; set; }
        public String Endereco { get; set; }
        public String NomeCondominio { get; set; }
        public int ConteinerId { get; set; }
        public Boolean Ativo { get; set; }        
    }
}
