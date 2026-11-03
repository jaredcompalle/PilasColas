using System;
using System.Windows.Forms;
using PilasColas.Estructuras;

namespace PilasColas
{
    /// <summary>
    /// Ventana principal: tres pestañas, cada una con un PanelEstructura.
    /// El diseño está en MainForm.Designer.cs (editable en Visual Studio).
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Cada panel recibe la estructura que controla y el texto de sus botones.
            panelPila.Configurar(n => new PilaEstatica(n), "Push", "Pop", "Peek");
            panelColaSimple.Configurar(n => new ColaSimple(n), "Enqueue", "Dequeue", "Front");
            panelColaCircular.Configurar(n => new ColaCircular(n), "Enqueue", "Dequeue", "Front");
        }
    }
}
