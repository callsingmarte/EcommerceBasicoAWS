using EcommerceBasicoAWS.Interfaces;
using EcommerceBasicoAWS.Services;
using EcommerceBasicoAWS.Models;
using EcommerceBasicoAWS.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace EcommerceBasicoAWS.Controllers
{
    public class TiendaController : Controller
    {
        private readonly IProductoService _productoService;
        private readonly ICategoriaService _categoriaService;

        public TiendaController(IProductoService productoService, ICategoriaService categoriaService, ICarritoService carritoService)
        {
            _productoService = productoService;
            _categoriaService = categoriaService;
        }

        public async Task<IActionResult> Index(ProductosViewModel productosVm)
        {
            ProductosViewModel vm = await _productoService.GetProductos(
                                            productosVm.SearchTypes,
                                            productosVm.Filters,
                                            productosVm.CurrentPage,
                                            productosVm.ResultsPerPage); 
            return View(vm);
        }

        public async Task<IActionResult> DetallesProducto(Guid idProducto)
        {
            Producto? producto = await _productoService.GetProducto(idProducto);
            List<Categoria> categorias = await _categoriaService.GetProductoCategorias(idProducto);

            ProductoCategoriasDetallesViewModel vm = new ProductoCategoriasDetallesViewModel()
            {
                Producto = producto,
                Categorias = categorias,
            };

            return View(vm);
        }

        public async Task<IActionResult> PedidoDetalles()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddPedido()
        {
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> CancelPedido()
        {
            return RedirectToAction(nameof(Index));
        }
    }
}
