using System;
using System.ComponentModel;
using System.Windows.Forms;
using PilasColas.Estructuras;

namespace PilasColas
{
    /// <summary>
    /// Panel reutilizable (UserControl) que muestra y controla una estructura.
    /// Se usa una vez por pestaña: Pila, Cola simple y Cola circular.
    /// Su diseño visual está en PanelEstructura.Designer.cs (editable en Visual Studio).
    /// </summary>
    public partial class PanelEstructura : UserControl
    {
        private IEstructura _estructura;
        private Func<int, IEstructura> _fabrica;

        public PanelEstructura()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Define qué estructura controla el panel y los textos de los botones.
        /// </summary>
        /// <param name="fabrica">Función que crea la estructura dado un tamaño.</param>
        public void Configurar(Func<int, IEstructura> fabrica, string textoInsertar, string textoExtraer, string textoVer)
        {
            _fabrica = fabrica;
            btnInsertar.Text = textoInsertar;
            btnExtraer.Text = textoExtraer;
            btnVer.Text = textoVer;
            CrearEstructura();
        }

        // ---------- Lógica interna ----------

        private void CrearEstructura()
        {
            if (_fabrica == null) return;
            _estructura = _fabrica((int)numCapacidad.Value);
            lstRegistro.Items.Clear();
            Registrar($"{_estructura.Nombre} creada con tamaño {_estructura.Capacidad}.");
            Refrescar();
        }

        /// <summary>Redibuja el arreglo y los punteros.</summary>
        private void Refrescar()
        {
            if (_estructura == null) return;
            lstArreglo.Items.Clear();
            string[] datos = _estructura.ObtenerArreglo();
            for (int i = 0; i < datos.Length; i++)
            {
                string valor = datos[i] ?? "(libre)";
                lstArreglo.Items.Add($"[{i}]  {valor,-12} {_estructura.EtiquetaIndice(i)}");
            }
            lblPunteros.Text = _estructura.DescribirPunteros();
        }

        private void Registrar(string mensaje)
        {
            lstRegistro.Items.Insert(0, $"{DateTime.Now:HH:mm:ss}  {mensaje}");
        }

        // ---------- Eventos de los botones ----------

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string dato = txtDato.Text.Trim();
            if (dato.Length == 0)
            {
                Registrar("Escribe un dato antes de insertar.");
                txtDato.Focus();
                return;
            }
            try
            {
                _estructura.Insertar(dato);
                Registrar($"{btnInsertar.Text}: se guardó \"{dato}\".");
                txtDato.Clear();
            }
            catch (InvalidOperationException ex)
            {
                Registrar("ERROR: " + ex.Message);
            }
            Refrescar();
            txtDato.Focus();
        }

        private void btnExtraer_Click(object sender, EventArgs e)
        {
            try
            {
                string dato = _estructura.Extraer();
                Registrar($"{btnExtraer.Text}: salió \"{dato}\".");
            }
            catch (InvalidOperationException ex)
            {
                Registrar("ERROR: " + ex.Message);
            }
            Refrescar();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            try
            {
                Registrar($"{btnVer.Text}: \"{_estructura.Ver()}\".");
            }
            catch (InvalidOperationException ex)
            {
                Registrar("ERROR: " + ex.Message);
            }
        }

        private void btnEstaVacia_Click(object sender, EventArgs e)
        {
            Registrar("isEmpty = " + (_estructura.EstaVacia() ? "true" : "false"));
        }

        private void btnEstaLlena_Click(object sender, EventArgs e)
        {
            Registrar("isFull = " + (_estructura.EstaLlena() ? "true" : "false"));
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            _estructura.Reiniciar();
            Registrar("Estructura reiniciada.");
            Refrescar();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            CrearEstructura();
        }

        private void txtDato_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnInsertar_Click(sender, EventArgs.Empty);
            }
        }
    }
}
