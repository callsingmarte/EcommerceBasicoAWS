using EcommerceBasicoAWS.Interfaces;
using EcommerceBasicoAWS.Models;
using Microsoft.AspNetCore.Identity;
using System.CodeDom;

namespace EcommerceBasicoAWS.Services
{
    public class CarritoService : ICarritoService
    {
        private readonly ICarritoRepository _carritoRepository;

        public CarritoService(ICarritoRepository carritoRepository)
        {
            _carritoRepository = carritoRepository;
        }

        public async Task<Carrito> CreateOrAddUserCarrito(string userId, ItemCarrito itemCarrito)
        {
            Carrito? carrito = await GetUserCarrito(userId);

            if (carrito == null) {
                Carrito carritoToAdd = new Carrito()
                {
                    IdUsuario = userId,
                    FechaCreacion = DateTime.Now,                    
                    Total = 0,
                };

               carrito = await _carritoRepository.CreateCarrito(carritoToAdd);
            }

            if (carrito != null) {
                //Comprobamos si ya existe un elemento con el mismo producto
                if (carrito.ItemsCarrito != null && carrito.ItemsCarrito.Count() > 0)
                {
                    ItemCarrito? itemCarritoExists = carrito.ItemsCarrito.FirstOrDefault(item => item.IdProducto == itemCarrito.IdProducto);

                    if(itemCarritoExists != null)
                    {
                        if(itemCarritoExists.Producto!.Stock >= itemCarrito.Cantidad + 1)
                        {
                            itemCarritoExists.Cantidad++;
                            itemCarritoExists.Subtotal = itemCarritoExists.Cantidad * itemCarritoExists.PrecioUnitario;
                        }

                        bool response = await _carritoRepository.UpdateCarritoItem(itemCarritoExists);
                        carrito = await _carritoRepository.GetUserCarrito(userId);
                    }
                    else
                    {
                        itemCarrito.IdItemCarrito = Guid.NewGuid();
                        itemCarrito.IdCarrito = carrito.IdCarrito;
                        await _carritoRepository.AddItemCarrito(carrito, itemCarrito);
                    }
                }
                else {
                    itemCarrito.IdItemCarrito = Guid.NewGuid();
                    itemCarrito.IdCarrito = carrito.IdCarrito;
                    await _carritoRepository.AddItemCarrito(carrito, itemCarrito);
                }
            }

            return carrito!;
        }

        public async Task<Carrito?> GetUserCarrito(string userId)
        {
            Carrito? carrito = await _carritoRepository.GetUserCarrito(userId);            

            return carrito;
        }

        public async Task<bool> RemoveItemCarrito(string userId, Guid idItemCarrito)
        {
            bool response = await _carritoRepository.RemoveItemCarrito(userId, idItemCarrito);

            return response;
        }

        public async Task<bool> DeleteUserCarrito(string userId)
        {
            bool response = await _carritoRepository.DeleteUserCarrito(userId);

            return response;
        }

        public async Task<bool> ClearCarritoItems(string userId)
        {
            bool response = await _carritoRepository.ClearCarritoItems(userId);

            return response;
        }

        public async Task<bool> UpdateCarritoItem(ItemCarrito itemCarrito)
        {
            bool response =  await _carritoRepository.UpdateCarritoItem(itemCarrito);
            
            return response;
        }

    }
}
