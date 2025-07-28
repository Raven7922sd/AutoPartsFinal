using AutoPartsFinal.Components.Models;
using AutoPartsFinal.Data;
using Microsoft.EntityFrameworkCore;

namespace AutoPartsFinal.Components.Services;

public class CarritoService(IDbContextFactory<ApplicationDbContext> DbFactory)
{
    private List<Carrito> _cartItems = new List<Carrito>();

    // Evento para notificar a los componentes cuando el carrito cambia
    public event Action? OnCartChanged;

    // Obtiene todos los artículos en el carrito
    public List<Carrito> GetCartItems() => _cartItems;

    // Obtiene el número total de artículos (unidades) en el carrito
    public int GetTotalItems() => _cartItems.Sum(item => item.Cantidad);

    // Obtiene el monto total del carrito
    public double GetTotalPrice() => _cartItems.Sum(item => item.Subtotal);

    // Agrega un producto al carrito o actualiza su cantidad si ya existe
    public void AddItem(Productos producto, int cantidad = 1)
    {
        var existingItem = _cartItems.FirstOrDefault(item => item.Producto.ProductoId == producto.ProductoId);

        if (existingItem != null)
        {
            existingItem.Cantidad += cantidad;
        }
        else
        {
            _cartItems.Add(new Carrito { Producto = producto, Cantidad = cantidad });
        }
        OnCartChanged?.Invoke(); // Notificar a los suscriptores que el carrito ha cambiado
    }

    // Remueve un producto del carrito
    public void RemoveItem(int productoId)
    {
        _cartItems.RemoveAll(item => item.Producto.ProductoId == productoId);
        OnCartChanged?.Invoke();
    }

    // Actualiza la cantidad de un producto específico en el carrito
    public void UpdateQuantity(int productoId, int newQuantity)
    {
        var existingItem = _cartItems.FirstOrDefault(item => item.Producto.ProductoId == productoId);
        if (existingItem != null)
        {
            if (newQuantity <= 0)
            {
                _cartItems.Remove(existingItem); // Eliminar si la cantidad es 0 o menos
            }
            else
            {
                existingItem.Cantidad = newQuantity;
            }
            OnCartChanged?.Invoke();
        }
    }

    // Limpia todo el carrito
    public void ClearCart()
    {
        _cartItems.Clear();
        OnCartChanged?.Invoke();
    }
}