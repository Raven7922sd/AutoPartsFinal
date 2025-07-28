using System.ComponentModel.DataAnnotations;
using AutoPartsFinal.Data;

namespace AutoPartsFinal.Components.Models;

public class Usuarios
{
    [Key]
    public int UsuarioId { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio")]
    [RegularExpression(@"^[^\d]*$", ErrorMessage = "Este campo no puede contener números")]
    public string UsuarioNombre { get; set; } = null!;

    [Required(ErrorMessage = "Este campo es obligatorio")]
    public string DireccionUsuario { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }=DateTime.Now;

    public string ApplicationUserId { get; set; }
    public ApplicationUser ApplicationUsers { get; set; }
}
