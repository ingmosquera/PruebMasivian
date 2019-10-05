using MasivianAPI.Repository.Entity;
using System.Threading.Tasks;

namespace MasivianAPI.Repository
{
    public interface IArbol
    {
        Task<NodoDTO> CrearArbol(int[] lista);
        Task<int> BuscarAncestroArbol(NodoDTO TodoArbol, int nodo1, int nodo2);
        Task<int> BuscarAncestroArreglo(int[] lista, int nodo1, int nodo2);
    }
}
