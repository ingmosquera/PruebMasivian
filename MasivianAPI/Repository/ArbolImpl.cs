using MasivianAPI.Repository.Entity;
using System.Threading.Tasks;

namespace MasivianAPI.Repository
{
    public class ArbolImpl : IArbol
    {

        public async Task<NodoDTO> CrearArbol(int[] lista) {
            var tempArbol = await Insertar(lista[0], null);
            var resultado = new NodoDTO();
            for (int i = 1; i < lista.Length; i++)
            {
                resultado = await Insertar(lista[i], tempArbol);
            }
            return resultado;
        }

        private async Task<NodoDTO> Insertar(int dato, NodoDTO nodo)
        {
            if (nodo == null)
            {
                return new NodoDTO
                {
                    Dato = dato,
                    ParDerecha = null,
                    ParIzquierda = null
                };
            }

            if (dato > nodo.Dato)
            {
                nodo.ParDerecha = await Insertar(dato, nodo.ParDerecha);
            }


            if (dato < nodo.Dato)
            {
                nodo.ParIzquierda = await Insertar(dato, nodo.ParIzquierda);
            }
            return nodo;
        }
       
    }
}
