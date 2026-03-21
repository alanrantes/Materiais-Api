using System.ComponentModel.DataAnnotations;

namespace Produtos_Entrega
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Codigo { get; set; }
        public decimal Preco { get; set; }
        public string? Descricao { get; set; }
        public int QtdEstoque { get; set; }
        public double Avaliacao { get; set; }
        public string? Categoria { get; set; }
    }
}
