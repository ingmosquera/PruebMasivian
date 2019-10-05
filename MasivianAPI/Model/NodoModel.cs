using MasivianAPI.Repository.Entity;
using System.Collections.Generic;

namespace MasivianAPI.Model
{
    public class NodoModel
    {
        public int Dato { get; set; }
        public NodoModel ParDerecha { get; set; }
        public NodoModel ParIzquierda { get; set; }



        public static implicit operator NodoDTO(NodoModel v)
        {
            return new NodoDTO() {
                Dato = v.Dato,
                ParDerecha = v.ParDerecha,
                ParIzquierda = v.ParIzquierda
            };
        }

        public class ArbolResultante
        {
            public string Lado { get; set; }
            public int Valor { get; set; }
        }

        public static List<ArbolResultante> ImprimirArbol(NodoDTO resultado, string lado, List<ArbolResultante> ListaResultante)
        {
            if (resultado == null) {
                return ListaResultante;
            }

            var arbolResultante = new ArbolResultante();
            arbolResultante.Lado = lado;
            arbolResultante.Valor = resultado.Dato;
            ListaResultante.Add(arbolResultante);

            if (resultado.ParIzquierda != null)
            {
                lado = "Izquierdo";
                ImprimirArbol(resultado.ParIzquierda, lado, ListaResultante);
            }

            if (resultado.ParDerecha != null)
            {
                lado = "Derecho";
                ImprimirArbol(resultado.ParDerecha, lado, ListaResultante);
            }

            return ListaResultante;
        }
    }

}
