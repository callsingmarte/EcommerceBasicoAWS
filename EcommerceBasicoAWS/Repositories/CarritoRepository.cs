using EcommerceBasicoAWS.Data;
using EcommerceBasicoAWS.Interfaces;
using EcommerceBasicoAWS.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceBasicoAWS.Repositories
{
    public class CarritoRepository : ICarritoRepository
    {

        private readonly ApplicationDbContext _context;

        public CarritoRepository(ApplicationDbContext context)
        {
           _context = context;
        }

        public async Task<bool> AddOrUpdateItemCarrito(ItemCarrito itemCarrito)
        {
            try
            {
                Carrito? carrito = await _context.Carritos.SingleOrDefaultAsync(c => c.IdCarrito == itemCarrito.IdCarrito);

                if (carrito == null) {
                    new Exception("No dispone de un carrito");
                }
                else
                {                    
                    ItemCarrito? itemCarritoExists = carrito.ItemsCarrito != null ? 
                        carrito.ItemsCarrito.SingleOrDefault(item => item.IdProducto == itemCarrito.IdProducto) : null;

                    if (itemCarritoExists != null)
                    {
                        itemCarritoExists.Cantidad = itemCarrito.Cantidad;
                        itemCarritoExists.Subtotal = itemCarrito.Subtotal;
                        _context.ItemsCarrito.Update(itemCarritoExists);
                        decimal subtotal = 0;
                        foreach (ItemCarrito item in carrito.ItemsCarrito)
                        {
                            subtotal += item.Subtotal;
                        }
                        carrito.Total = subtotal;
                    }
                    else
                    {
                        _context.ItemsCarrito.Add(itemCarrito);
                        carrito.Total += itemCarrito.Subtotal;
                        _context.Carritos.Update(carrito);
                    }


                    _context.SaveChanges();
                }

                return true;
            }
            catch (Exception ex) {
                return false;
            }
        }

        public async Task<bool> ClearCarritoItems(string userId)
        {
            bool response = false;
            Carrito? carrito = await GetUserCarrito(userId);
            if (carrito != null) {
                carrito.ItemsCarrito.Clear();
                carrito.Total = 0;
                _context.SaveChanges();
                response = true;
            }

            return response;
        }

        public async Task<Carrito> CreateCarrito(Carrito carrito)
        {
            await _context.Carritos.AddAsync(carrito);
            _context.SaveChanges();

            return carrito;
        }

        public async Task<bool> DeleteUserCarrito(string userId)
        {
            Carrito? carrito = await GetUserCarrito(userId);
            bool response = false;
            if (carrito != null) {
                _context.Carritos.Remove(carrito);
                _context.SaveChanges();
                response = true;
            }

            return response;
        }

        public async Task<ItemCarrito?> GetItemCarrito(string userId, Guid idItemCarrito)
        {
            Carrito? carrito = await GetUserCarrito(userId);
            ItemCarrito? itemcarrito = null;
            if(carrito != null)
            {
                itemcarrito = carrito.ItemsCarrito.SingleOrDefault(i => i.IdItemCarrito == idItemCarrito);
            }

            return itemcarrito;
        }

        public async Task<Carrito?> GetUserCarrito(string userId)
        {
            Carrito? carrito = await _context.Carritos.Include(c => c.ItemsCarrito).ThenInclude(item => item.Producto).FirstOrDefaultAsync(c => c.IdUsuario == userId);

            return carrito;
        }

        public async Task<bool> RemoveItemCarrito(string userId, Guid idItemCarrito)
        {
            Carrito? carrito = await GetUserCarrito(userId);
            bool response = false;
            if(carrito != null)
            {                
                ItemCarrito? itemCarrito = carrito.ItemsCarrito.SingleOrDefault(i => i.IdItemCarrito == idItemCarrito);

                if (itemCarrito != null) {
                    carrito.Total -= itemCarrito.Subtotal;
                    _context.ItemsCarrito.Remove(itemCarrito);
                    _context.SaveChanges();
                    response = true;
                }
            }

            return response;
        }

        public async Task<bool> UpdateCarritoItem(ItemCarrito itemCarrito)
        {
            _context.ItemsCarrito.Update(itemCarrito);
            Carrito? carrito = _context.Carritos.SingleOrDefault(c => c.IdCarrito == itemCarrito.IdCarrito);
            if(carrito != null)
            {
                decimal subtotal = 0;
                foreach(ItemCarrito item in carrito.ItemsCarrito)
                {
                    if(item.IdProducto == itemCarrito.IdProducto)
                    {
                        subtotal += itemCarrito.Subtotal;
                    }
                    else
                    {
                        subtotal += item.Subtotal;
                    }
                }

                carrito.Total = subtotal;
            }
            _context.SaveChanges();

            return true;
        }
    }
}
