using MasivianAPI.Model;
using MasivianAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace MasivianAPI.Controllers.v1
{
    [Route("v1/[controller]")]
    [ApiController]
    public class ArbolBinarioController : ControllerBase
    {
        private readonly IArbol arbol;
        public ArbolBinarioController(IArbol arbol)
        {
            this.arbol = arbol;
        }

        [HttpPost("CrearArbol")]
        public async Task<IActionResult> Post(int[] arreglo) {
            try
            {
                var result = await arbol.CrearArbol(arreglo);
                return Ok(result);
            }
            catch (Exception)
            {
                return BadRequest("Error al crear el arbol");
            }
        }

        [HttpGet]
        public IActionResult GetNodo(NodoModel Arbol, int nodo1, int nodo2)
        {
            return Ok("Mensaje");
        }
    }
}