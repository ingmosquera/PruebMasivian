using MasivianAPI.Model;
using MasivianAPI.Repository;
using MasivianAPI.Repository.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static MasivianAPI.Model.NodoModel;

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
                var lista = new List<ArbolResultante>();
                var ResultadoArbol = NodoModel.ImprimirArbol(result, "Inicio", lista);
                return Ok(ResultadoArbol);
            }
            catch (Exception)
            {
                return BadRequest("Error al crear el arbol");
            }
        }

        [HttpGet("MostrarAncestroRaiz")]
        public async Task<IActionResult> GetAncestroRaiz(NodoModel infoArbol, int nodo1, int nodo2)
        {
            try
            {
                var nodo = new NodoDTO()
                {
                    Dato = infoArbol.Dato,
                    ParDerecha = infoArbol.ParDerecha,
                    ParIzquierda = infoArbol.ParIzquierda
                };

                var result = await arbol.BuscarAncestroArbol(nodo, nodo1,nodo2);
                
                return Ok("Ancestro mas cercano es:"+ result);
            }
            catch (Exception)
            {
                return BadRequest("Error al buscar el ancestro");
            }
        }

        [HttpGet("MostrarAncestroArreglo")]
        public async Task<IActionResult> GetAncestroArreglo(int[] arreglo, int nodo1, int nodo2)
        {
            try
            {
                var resultado = await arbol.BuscarAncestroArreglo(arreglo, nodo1, nodo2);
                return Ok("Ancestro mas cercano es:" + resultado);
            }
            catch (Exception)
            {
                return BadRequest("Error al buscar el ancestro");
            }
        }

    }
}