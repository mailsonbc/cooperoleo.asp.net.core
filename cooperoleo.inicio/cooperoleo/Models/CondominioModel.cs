using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cooperoleo.Models
{
    [Table("Condominio")]
    public class CondominioModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id do condomínio")]
        [HiddenInput]
        public int? CondominioId { get; set; }

        [ForeignKey("ContatoId")]
        public ContatoModel? Contato { get; set; }
        public int? ContatoId { get; set; }

        [Display(Name = "Endereço")]
        [MaxLength(100, ErrorMessage = "O tamanho máximo do nome é de 100 caracteres!")]
        [MinLength(10, ErrorMessage = "Digite um nome com mais de dez caracteres")]
        public String? Endereco { get; set; }

        [Display(Name = "Nome do condomínio")]
        [Required]
        [MaxLength(70, ErrorMessage = "O tamanho máximo do nome é de 70 caracteres!")]
        [MinLength(5, ErrorMessage = "Digite um nome com mais de cinco caracteres")]
        public String? NomeCondominio { get; set; }

        [Display(Name = "Id do Contêiner")]
        public int? ConteinerId { get; set; }

        [ForeignKey("ConteinerId")]
        public ConteinerModel? Conteiner { get; set; }

        public Boolean? Ativo { get; set; }        
    }
}
