using System.ComponentModel.DataAnnotations;

namespace BlazorProjectWindows.Models;

public class Product
{
    [Key]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Informe o nome da categoria")]
    [MinLength(3, ErrorMessage = "Tamanho minimo 3 caracteres")]
    [MaxLength(50, ErrorMessage = "Tamanho maximo 50 caracteres")]
    public string Title { get; set; } = string.Empty;
    
    public string? Description { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Informe um preco")]
    [DataType(DataType.Currency)]
    public decimal Price { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;
}