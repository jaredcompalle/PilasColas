using System;

namespace PilasColas.Estructuras
{
    /// <summary>
    /// Pila (LIFO) implementada con un arreglo estático y un puntero "top".
    /// No usa colecciones nativas de C#.
    /// </summary>
    public class PilaEstatica : IEstructura
    {
        private readonly string[] _datos;
        private int _top;                    // -1 = pila vacía

        public PilaEstatica(int capacidad)
        {
            if (capacidad < 1) throw new ArgumentException("La capacidad debe ser mayor a 0.");
            _datos = new string[capacidad];
            _top = -1;
        }

        public string Nombre => "Pila";
        public int Capacidad => _datos.Length;
        public int Cantidad => _top + 1;

        public bool EstaVacia() => _top == -1;
        public bool EstaLlena() => _top == _datos.Length - 1;

        /// <summary>Push: incrementa top y guarda el dato.</summary>
        public void Insertar(string dato)
        {
            if (EstaLlena())
                throw new InvalidOperationException("Desbordamiento: la pila está llena.");
            _top++;
            _datos[_top] = dato;
        }

        /// <summary>Pop: devuelve el dato en top y decrementa top.</summary>
        public string Extraer()
        {
            if (EstaVacia())
                throw new InvalidOperationException("Subdesbordamiento: la pila está vacía.");
            string dato = _datos[_top];
            _datos[_top] = null;
            _top--;
            return dato;
        }

        /// <summary>Peek: consulta el tope sin retirarlo.</summary>
        public string Ver()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La pila está vacía, no hay tope.");
            return _datos[_top];
        }

        public void Reiniciar()
        {
            for (int i = 0; i < _datos.Length; i++) _datos[i] = null;
            _top = -1;
        }

        public string[] ObtenerArreglo()
        {
            string[] copia = new string[_datos.Length];
            for (int i = 0; i < _datos.Length; i++) copia[i] = _datos[i];
            return copia;
        }

        public string DescribirPunteros() =>
            $"top = {_top}   |   elementos = {Cantidad}/{Capacidad}   |   vacía: {(EstaVacia() ? "sí" : "no")}   |   llena: {(EstaLlena() ? "sí" : "no")}";

        public string EtiquetaIndice(int i) => i == _top ? "<- top" : "";
    }
}
