namespace MasivianAPI.Repository.Entity
{
    public class NodoDTO
    {
        public int Dato { get; set; }
        public NodoDTO ParDerecha { get; set; }
        public NodoDTO ParIzquierda { get; set; }
    }
}
