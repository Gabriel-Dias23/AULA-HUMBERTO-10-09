using AULA_HUMBERTO_03_09.Validaions;
using exemploCrud.Validations;
using System.ComponentModel.DataAnnotations;

namespace exemploCrud.Models
{
    public class AlunoDTO
    {
        [CpfValidation(ErrorMessage = "Digite um cpf valido")]
        [Required(ErrorMessage = "Cpf Obrigatório")]
        public string cpf { get; set; }
        public string nome { get; set; }

        [RAValidation]
        [Required(ErrorMessage = "Começe escrevendo com RA")]
        [MaxLength(6, ErrorMessage = "Digite no maximo 8 caracteres ")]
        public string RA { get; set; }
        //RA049341

        [StringLength(250)]
        [MinLength(10)]
        public string Email { get; set; }

        public string Ativo { get; set;}
    }
}