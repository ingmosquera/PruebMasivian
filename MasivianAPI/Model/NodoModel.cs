namespace MasivianAPI.Model
{
    public class NodoModel
    {
        public int Dato { get; set; }
        public NodoModel ParDerecha { get; set; }
        public NodoModel ParIzquierda { get; set; }
    }

}
