using Microsoft.AspNetCore.Mvc;
using MyApp2.Models;

namespace MyApp2.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(){
            var miProducto  = new ProductItem();
            miProducto.Id=1;
            miProducto.Name="Naranja";
            miProducto.Tipo="Fruta";

            //ViewData["NombreProducto"] = miProducto.Name;
            //ViewData["TipoProducto"] = miProducto.Tipo;
            //ViewBag.NombreProducto= miProducto.Name;
            //ViewBag.TipoProducto= miProducto.Tipo;

            return View(miProducto);
            //return View();
        }
    }
}