using MasivianAPI.Repository.Entity;
using System.Threading.Tasks;

namespace MasivianAPI.Repository
{
    public interface IArbol
    {
        Task<NodoDTO> CrearArbol(int[] lista);
    }
}
