using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cooperoleo.Models
{
    [Table("Conteineres")]
    public class ConteinerModel
    {
        [Display(Name = "Id do Contêiner")]
        [HiddenInput]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? ConteinerId { get; set; }

        [Display(Name = "Disponivel?")]
        public Boolean? Disponibilidade { get; set; }

        public Boolean? Ativo { get; set; }
    }
}
