using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cooperoleo.Models
{
    [Table("Contato")]
    public class ContatoModel
    {
        [Display(Name = "Id do Contato")]
        [HiddenInput]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? ContatoId { get; set; }

        [Display(Name = "Nome do cliente")]
        [Required(ErrorMessage = "Nome do cliente é obrigatório")]
        [MaxLength(70, ErrorMessage = "O tamanho máximo do nome é de 70 caracteres!")]
        [MinLength(2, ErrorMessage = "Digite um nome com mais de dois caracteres")]
        public String? Nome { get; set; }

        [Display(Name = "CPF")]
        [MaxLength(11)]
        public String? Cpf { get; set; }

        [Display(Name = "Telefone")]
        [MaxLength(15)]
        public String? Telefone { get; set; }
        public Boolean? Ativo { get; set; }
    }
}
