using System.ComponentModel.DataAnnotations;
using Validations;

namespace Models
{
    public class Produto
    {
        [Required(ErrorMessage = "Descrição é obrigatória.")]
        public string Descricao { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Preço deve ser positivo.")]
        public double Preco { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Estoque não pode ser negativo.")]
        public int Estoque { get; set; }

        [Required(ErrorMessage = "Código do produto é obrigatório.")]
        [CodigoProduto]
        public string CodigoProduto { get; set; }
    }
}
