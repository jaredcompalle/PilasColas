using System;

namespace PilasColas.Estructuras
{
    /// <summary>
    /// Cola circular (FIFO) con arreglo estático, punteros "front" y "rear"
    /// y un contador "count". Usa aritmética modular para reutilizar los espacios liberados.
    /// </summary>
    public class ColaCircular : IEstructura
    {
        private readonly string[] _datos;
        private int _front;                  // índice del primer elemento
        private int _rear;                   // índice del último elemento
        private int _count;                  // cantidad de elementos

        public ColaCircular(int capacidad)
        {
            if (capacidad < 1) throw new ArgumentException("La capacidad debe ser mayor a 0.");
            _datos = new string[capacidad];
            _front = 0;
            _rear = -1;
            _count = 0;
        }

        public string Nombre => "Cola circular";
        public int Capacidad => _datos.Length;
        public int Cantidad => _count;

        public bool EstaVacia() => _count == 0;
        public bool EstaLlena() => _count == _datos.Length;

        /// <summary>Enqueue: rear = (rear + 1) % capacidad.</summary>
        public void Insertar(string dato)
        {
            if (EstaLlena())
                throw new InvalidOperationException("Desbordamiento: la cola circular está llena.");
            _rear = (_rear + 1) % _datos.Length;
            _datos[_rear] = dato;
            _count++;
        }

        /// <summary>Dequeue: front = (front + 1) % capacidad.</summary>
        public string Extraer()
        {
            if (EstaVacia())
                throw new InvalidOperationException("Subdesbordamiento: la cola circular está vacía.");
            string dato = _datos[_front];
            _datos[_front] = null;
            _front = (_front + 1) % _datos.Length;
            _count--;
            return dato;
        }

        /// <summary>Front: consulta el primer elemento sin retirarlo.</summary>
        public string Ver()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La cola circular está vacía, no hay frente.");
            return _datos[_front];
        }

        public void Reiniciar()
        {
            for (int i = 0; i < _datos.Length; i++) _datos[i] = null;
            _front = 0;
            _rear = -1;
            _count = 0;
        }

        public string[] ObtenerArreglo()
        {
            string[] copia = new string[_datos.Length];
            for (int i = 0; i < _datos.Length; i++) copia[i] = _datos[i];
            return copia;
        }

        public string DescribirPunteros() =>
            $"front = {_front}   |   rear = {_rear}   |   count = {_count}/{Capacidad}   |   vacía: {(EstaVacia() ? "sí" : "no")}   |   llena: {(EstaLlena() ? "sí" : "no")}";

        public string EtiquetaIndice(int i)
        {
            string etiqueta = "";
            if (!EstaVacia() && i == _front) etiqueta += "<- front ";
            if (!EstaVacia() && i == _rear) etiqueta += "<- rear";
            return etiqueta.Trim();
        }
    }
}
