using System.Reflection.Emit;
using AutoPartsFinal.Components.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AutoPartsFinal.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Productos> Producto { get; set; }
    public DbSet<Usuarios> Usuario { get; set; }
    public DbSet<Ventas> Ventas { get; set; }
    public DbSet<VentasDetalles> VentasDetalle { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Id = "04",
                Name = "Admin",
                NormalizedName = "ADMIN"
            },
            new IdentityRole
            {
                Id = "03",
                Name = "User",
                NormalizedName = "USER"
            }
        );
    }
}