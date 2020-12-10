using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoTCC.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(30)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        public int? CategoriaId { get; set; }
        [ForeignKey("CategoriaId")]
        [Display(Name = "Categoria Principal")]
        public Categoria CategoriaPai { get; set; }

        [StringLength(300)]
        public string Imagem { get; set; }

        public bool ExibirCardapio { get; set; }

        public virtual List<Produto> Produtos { get; set; }

        [NotMapped]
        public string NomeCompleto { get => CategoriaPai != null ? string.Concat(CategoriaPai.Nome, " ", Nome) : Nome; }
    }

    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Nome { get; set; }

        [StringLength(200)]
        public string Descricao { get; set; }

        [DataType(DataType.Currency)]
        public double Valor1 { get; set; }

        [DataType(DataType.Currency)]
        public double? Valor2 { get; set; }

        public int CategoriaId { get; set; }
        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }
    }

}
