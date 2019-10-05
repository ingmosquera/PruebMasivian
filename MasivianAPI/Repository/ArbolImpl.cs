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

        public async Task<int> BuscarAncestroArreglo(int[] lista, int nodo1, int nodo2) {
            var arbol = await CrearArbol(lista);
            return  await BuscarAncestroArbol(arbol, nodo1,nodo2);
        }

        public async Task<int> BuscarAncestroArbol(NodoDTO TodoArbol, int nodo1, int nodo2)
        {
            int tempPadre = TodoArbol.Dato;
            if (nodo1 > tempPadre && nodo2 > tempPadre)
            {
                if (TodoArbol.ParDerecha != null)
                {
                    return await BuscarAncestroArbol(TodoArbol.ParDerecha, nodo1, nodo2);
                }
            }

            if (nodo1 < TodoArbol.Dato && nodo2 < TodoArbol.Dato)
            {
                if (TodoArbol.ParDerecha != null)
                {
                    return await BuscarAncestroArbol(TodoArbol.ParIzquierda, nodo1, nodo2);
                }
            }
            return tempPadre;
        }
    }
}
