namespace PilasColas
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            lblAlumno = new System.Windows.Forms.Label();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPila = new System.Windows.Forms.TabPage();
            panelPila = new PanelEstructura();
            tabColaSimple = new System.Windows.Forms.TabPage();
            panelColaSimple = new PanelEstructura();
            tabColaCircular = new System.Windows.Forms.TabPage();
            panelColaCircular = new PanelEstructura();
            tabControl1.SuspendLayout();
            tabPila.SuspendLayout();
            tabColaSimple.SuspendLayout();
            tabColaCircular.SuspendLayout();
            SuspendLayout();
            //
            // lblAlumno
            //
            lblAlumno.BackColor = System.Drawing.Color.FromArgb(31, 56, 100);
            lblAlumno.Dock = System.Windows.Forms.DockStyle.Top;
            lblAlumno.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblAlumno.ForeColor = System.Drawing.Color.White;
            lblAlumno.Location = new System.Drawing.Point(0, 0);
            lblAlumno.Name = "lblAlumno";
            lblAlumno.Size = new System.Drawing.Size(800, 40);
            lblAlumno.Text = "Rosembert Jared Ortiz Reyes  |  I25050406  |  TECNM  |  Maestro: Ruben Riojas";
            lblAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // tabControl1
            //
            tabControl1.Controls.Add(tabPila);
            tabControl1.Controls.Add(tabColaSimple);
            tabControl1.Controls.Add(tabColaCircular);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            tabControl1.Location = new System.Drawing.Point(0, 40);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(800, 520);
            tabControl1.TabIndex = 0;
            //
            // tabPila
            //
            tabPila.Controls.Add(panelPila);
            tabPila.Location = new System.Drawing.Point(4, 30);
            tabPila.Name = "tabPila";
            tabPila.Padding = new System.Windows.Forms.Padding(3);
            tabPila.Size = new System.Drawing.Size(792, 486);
            tabPila.TabIndex = 0;
            tabPila.Text = "Pila (LIFO)";
            tabPila.UseVisualStyleBackColor = true;
            //
            // panelPila
            //
            panelPila.Dock = System.Windows.Forms.DockStyle.Fill;
            panelPila.Location = new System.Drawing.Point(3, 3);
            panelPila.Name = "panelPila";
            panelPila.Size = new System.Drawing.Size(786, 480);
            panelPila.TabIndex = 0;
            //
            // tabColaSimple
            //
            tabColaSimple.Controls.Add(panelColaSimple);
            tabColaSimple.Location = new System.Drawing.Point(4, 30);
            tabColaSimple.Name = "tabColaSimple";
            tabColaSimple.Padding = new System.Windows.Forms.Padding(3);
            tabColaSimple.Size = new System.Drawing.Size(792, 486);
            tabColaSimple.TabIndex = 1;
            tabColaSimple.Text = "Cola simple (FIFO)";
            tabColaSimple.UseVisualStyleBackColor = true;
            //
            // panelColaSimple
            //
            panelColaSimple.Dock = System.Windows.Forms.DockStyle.Fill;
            panelColaSimple.Location = new System.Drawing.Point(3, 3);
            panelColaSimple.Name = "panelColaSimple";
            panelColaSimple.Size = new System.Drawing.Size(786, 480);
            panelColaSimple.TabIndex = 0;
            //
            // tabColaCircular
            //
            tabColaCircular.Controls.Add(panelColaCircular);
            tabColaCircular.Location = new System.Drawing.Point(4, 30);
            tabColaCircular.Name = "tabColaCircular";
            tabColaCircular.Padding = new System.Windows.Forms.Padding(3);
            tabColaCircular.Size = new System.Drawing.Size(792, 486);
            tabColaCircular.TabIndex = 2;
            tabColaCircular.Text = "Cola circular (FIFO)";
            tabColaCircular.UseVisualStyleBackColor = true;
            //
            // panelColaCircular
            //
            panelColaCircular.Dock = System.Windows.Forms.DockStyle.Fill;
            panelColaCircular.Location = new System.Drawing.Point(3, 3);
            panelColaCircular.Name = "panelColaCircular";
            panelColaCircular.Size = new System.Drawing.Size(786, 480);
            panelColaCircular.TabIndex = 0;
            //
            // MainForm
            //
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 560);
            Controls.Add(tabControl1);
            Controls.Add(lblAlumno);
            MinimumSize = new System.Drawing.Size(816, 599);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Tarea 3.1 - Pilas y Colas con memoria estática";
            tabControl1.ResumeLayout(false);
            tabPila.ResumeLayout(false);
            tabColaSimple.ResumeLayout(false);
            tabColaCircular.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPila;
        private PanelEstructura panelPila;
        private System.Windows.Forms.TabPage tabColaSimple;
        private PanelEstructura panelColaSimple;
        private System.Windows.Forms.TabPage tabColaCircular;
        private PanelEstructura panelColaCircular;
    }
}
