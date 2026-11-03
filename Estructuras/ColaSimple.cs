using System;

namespace PilasColas.Estructuras
{
    /// <summary>
    /// Cola simple (FIFO) con arreglo estático y punteros "front" y "rear".
    /// Limitación: los espacios liberados al inicio NO se reutilizan;
    /// la cola se considera llena cuando rear llega al final del arreglo.
    /// </summary>
    public class ColaSimple : IEstructura
    {
        private readonly string[] _datos;
        private int _front;                  // índice del primer elemento
        private int _rear;                   // índice del último elemento (-1 = nunca se encoló)

        public ColaSimple(int capacidad)
        {
            if (capacidad < 1) throw new ArgumentException("La capacidad debe ser mayor a 0.");
            _datos = new string[capacidad];
            _front = 0;
            _rear = -1;
        }

        public string Nombre => "Cola simple";
        public int Capacidad => _datos.Length;
        public int Cantidad => EstaVacia() ? 0 : _rear - _front + 1;

        public bool EstaVacia() => _front > _rear;
        public bool EstaLlena() => _rear == _datos.Length - 1;

        /// <summary>Enqueue: avanza rear y guarda el dato.</summary>
        public void Insertar(string dato)
        {
            if (EstaLlena())
                throw new InvalidOperationException("Cola llena: rear llegó al final del arreglo (la cola simple no reutiliza espacios).");
            _rear++;
            _datos[_rear] = dato;
        }

        /// <summary>Dequeue: devuelve el dato en front y avanza front.</summary>
        public string Extraer()
        {
            if (EstaVacia())
                throw new InvalidOperationException("Subdesbordamiento: la cola está vacía.");
            string dato = _datos[_front];
            _datos[_front] = null;
            _front++;
            return dato;
        }

        /// <summary>Front: consulta el primer elemento sin retirarlo.</summary>
        public string Ver()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La cola está vacía, no hay frente.");
            return _datos[_front];
        }

        public void Reiniciar()
        {
            for (int i = 0; i < _datos.Length; i++) _datos[i] = null;
            _front = 0;
            _rear = -1;
        }

        public string[] ObtenerArreglo()
        {
            string[] copia = new string[_datos.Length];
            for (int i = 0; i < _datos.Length; i++) copia[i] = _datos[i];
            return copia;
        }

        public string DescribirPunteros() =>
            $"front = {_front}   |   rear = {_rear}   |   elementos = {Cantidad}/{Capacidad}   |   vacía: {(EstaVacia() ? "sí" : "no")}   |   llena: {(EstaLlena() ? "sí" : "no")}";

        public string EtiquetaIndice(int i)
        {
            string etiqueta = "";
            if (!EstaVacia() && i == _front) etiqueta += "<- front ";
            if (!EstaVacia() && i == _rear) etiqueta += "<- rear";
            return etiqueta.Trim();
        }
    }
}
