using System.ComponentModel.DataAnnotations;

namespace BlazorProjectWindows.Models;

public class Category
{
    [Key]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Informe o nome da categoria")]
    [MinLength(3, ErrorMessage = "Tamanho minimo 3 caracteres")]
    [MaxLength(50, ErrorMessage = "Tamanho maximo 50 caracteres")]
    public string Title { get; set; } = string.Empty;
}