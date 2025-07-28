using System.ComponentModel.DataAnnotations;

namespace AutoPartsFinal.Components.Models;
public class Productos
{
    [Key]
    public int ProductoId { get; set; }

    [Required(ErrorMessage ="Campo obligatorio.")]
    [StringLength(200, ErrorMessage = "Máximo 200 caracteres.")]
    public string ProductoNombre { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Campo obligatorio.")]
    [Range(0.1, 999999999, ErrorMessage = "Máximo 999,999,999 de coste por producto.")]
    public double ProductoMonto { get; set; }

    [Required(ErrorMessage = "Campo obligatorio.")]
    [Range(1, 500000, ErrorMessage = "Debe ingresar una cantidad entre 1 y 500,000.")]
    public double ProductoCantidad { get; set; }
    
    [Required(ErrorMessage = "Campo obligatorio.")]
    [StringLength(500, ErrorMessage = "Máximo 500 caracteres.")]
    public string ProductoDescripcion { get; set; } = string.Empty;

    [Required(ErrorMessage = "La URL de la imagen es obligatoria.")]
    public string ProductoImagenUrl { get; set; } = string.Empty;
    public DateTime Fecha { get; set; }= DateTime.Now;
}