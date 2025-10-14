using EcommerceBasicoAWS.Interfaces;
using EcommerceBasicoAWS.Models;
using EcommerceBasicoAWS.Services;
using EcommerceBasicoAWS.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace EcommerceBasicoAWS.Controllers
{
    public class CarritoController : Controller
    {
        private readonly ICarritoService _carritoService;
        private readonly IProductoService _productoService;

        public CarritoController(ICarritoService carritoService, IProductoService productoService)
        {
            _carritoService = carritoService;
            _productoService = productoService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            Carrito? carrito = await _carritoService.GetUserCarrito(userId);

            return View(carrito);
        }

        [HttpGet]
        public async Task<IActionResult> GetCarrito()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            Carrito? carrito = await _carritoService.GetUserCarrito(userId);

            return Json(carrito);
        }


        [HttpPost]
        public async Task<IActionResult> AddCarritoItem(Guid idProducto, int cantidad, string productoMainImageUrl)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            Producto? producto = await _productoService.GetProducto(idProducto);

            Carrito carrito = null;

            if (producto != null)
            {
                ItemCarrito itemCarrito = new ItemCarrito()
                {
                    IdProducto = idProducto,
                    Cantidad = cantidad,
                    FechaCreacion = DateTime.Now,
                    PrecioUnitario = producto.Precio,
                    Subtotal = producto.Precio * cantidad,
                    MainImageUrl = productoMainImageUrl,
                };
                
                carrito = await _carritoService.CreateOrAddUserCarrito(userId, itemCarrito);
            }

            return View(nameof(Index), carrito);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCarrito(Guid idProducto, int cantidad)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            Producto? producto = await _productoService.GetProducto(idProducto);

            Carrito? carrito = userId != null ? await _carritoService.GetUserCarrito(userId) : null;

            cantidad = (cantidad <= 0) ? 1 : cantidad;

            if (producto != null && carrito != null)
            {
                if(producto.Stock < cantidad)
                {
                    cantidad = producto.Stock;
                }

                if (carrito.ItemsCarrito != null) {
                    ItemCarrito? itemCarrito = carrito.ItemsCarrito.SingleOrDefault(item => item.IdProducto == idProducto);
                    if (itemCarrito != null)
                    {
                        if (itemCarrito.Cantidad == cantidad)
                        {
                            return Ok("no es necesario actualizar el carrito");
                        }

                        itemCarrito.Cantidad = cantidad;
                        bool response = await _carritoService.UpdateCarritoItem(itemCarrito);
                        if (response) {
                            return Ok("Carrito actualizado");
                        }
                    }
                }
            }

            return Ok("Carrito no se ha actualizado");
        }

        [HttpPatch]
        public async Task<IActionResult> AddOrRemoveItemCarrito(Guid idProducto, bool add)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            Producto? producto = await _productoService.GetProducto(idProducto);

            Carrito? carrito = userId != null ? await _carritoService.GetUserCarrito(userId) : null;

            if(producto != null && carrito != null)
            {
                ItemCarrito? item = carrito.ItemsCarrito.FirstOrDefault(item => item.IdProducto == idProducto);

                if(item != null)
                {
                    item.Cantidad = add ? ++item.Cantidad : --item.Cantidad;

                    if (item.Cantidad <= 0)
                    {
                        return Ok("No se ha podido actualizar el carrito");
                    }

                    if (item.Cantidad > item.Producto.Stock)
                    {
                        return Ok("No se ha podido actualizar el carrito");
                    }

                    bool response = await _carritoService.UpdateCarritoItem(item);

                    if (response) {
                        return Ok("Carrito Actualizado");
                    }
                }
            }

            return Ok("No se ha podido actualizar el carrito");
        }


        [HttpPost]
        public async Task<IActionResult> RemoveCarritoItem(Guid idItemCarrito)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            bool response = await _carritoService.RemoveItemCarrito(userId, idItemCarrito);
            Carrito? carrito = await _carritoService.GetUserCarrito(userId);

            return View(nameof(Index), carrito);
        }

        [HttpPut]
        public async Task<IActionResult> RemoveCarritoItemAjax(Guid idItemCarrito)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            bool response = await _carritoService.RemoveItemCarrito(userId, idItemCarrito);

            return response ? Ok("item eliminado del carrito") : Ok("No se ha podido eliminar el item");
        }

        [HttpPost]
        public async Task<IActionResult> ClearCarritoItems()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            bool response = await _carritoService.ClearCarritoItems(userId);
            Carrito? carrito = await _carritoService.GetUserCarrito(userId);

            return View(nameof(Index), carrito);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteUserCarrito()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            bool response = await _carritoService.DeleteUserCarrito(userId);

            return RedirectToAction("Index", "Tienda");
        }
    }
}
