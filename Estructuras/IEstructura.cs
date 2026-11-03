using System;

namespace PilasColas.Estructuras
{
    /// <summary>
    /// Contrato común de las tres estructuras (Pila, Cola simple y Cola circular).
    /// Permite que la interfaz gráfica use el mismo panel para todas.
    /// Insertar/Extraer/Ver lanzan InvalidOperationException si la operación no es válida
    /// (desbordamiento o subdesbordamiento).
    /// </summary>
    public interface IEstructura
    {
        string Nombre { get; }
        int Capacidad { get; }
        int Cantidad { get; }

        void Insertar(string dato);   // Push / Enqueue
        string Extraer();             // Pop / Dequeue
        string Ver();                 // Peek / Front
        bool EstaVacia();
        bool EstaLlena();
        void Reiniciar();

        /// <summary>Copia del arreglo interno (null = casilla libre).</summary>
        string[] ObtenerArreglo();

        /// <summary>Texto con el valor actual de los punteros.</summary>
        string DescribirPunteros();

        /// <summary>Etiqueta para una posición (por ejemplo "&lt;- top", "&lt;- front").</summary>
        string EtiquetaIndice(int i);
    }
}
