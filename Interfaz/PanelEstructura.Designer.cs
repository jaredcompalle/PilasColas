namespace PilasColas
{
    partial class PanelEstructura
    {
        /// <summary>Variable del diseñador necesaria.</summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        private void InitializeComponent()
        {
            lblDato = new System.Windows.Forms.Label();
            txtDato = new System.Windows.Forms.TextBox();
            lblTamano = new System.Windows.Forms.Label();
            numCapacidad = new System.Windows.Forms.NumericUpDown();
            btnCrear = new System.Windows.Forms.Button();
            btnInsertar = new System.Windows.Forms.Button();
            btnExtraer = new System.Windows.Forms.Button();
            btnVer = new System.Windows.Forms.Button();
            btnEstaVacia = new System.Windows.Forms.Button();
            btnEstaLlena = new System.Windows.Forms.Button();
            btnReiniciar = new System.Windows.Forms.Button();
            lblArreglo = new System.Windows.Forms.Label();
            lstArreglo = new System.Windows.Forms.ListBox();
            lblRegistro = new System.Windows.Forms.Label();
            lstRegistro = new System.Windows.Forms.ListBox();
            lblPunteros = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)numCapacidad).BeginInit();
            SuspendLayout();
            //
            // lblDato
            //
            lblDato.AutoSize = true;
            lblDato.Location = new System.Drawing.Point(15, 19);
            lblDato.Name = "lblDato";
            lblDato.Size = new System.Drawing.Size(35, 15);
            lblDato.Text = "Dato:";
            //
            // txtDato
            //
            txtDato.Location = new System.Drawing.Point(65, 15);
            txtDato.Name = "txtDato";
            txtDato.Size = new System.Drawing.Size(150, 23);
            txtDato.TabIndex = 0;
            txtDato.KeyDown += new System.Windows.Forms.KeyEventHandler(txtDato_KeyDown);
            //
            // lblTamano
            //
            lblTamano.AutoSize = true;
            lblTamano.Location = new System.Drawing.Point(245, 19);
            lblTamano.Name = "lblTamano";
            lblTamano.Size = new System.Drawing.Size(48, 15);
            lblTamano.Text = "Tamaño:";
            //
            // numCapacidad
            //
            numCapacidad.Location = new System.Drawing.Point(300, 15);
            numCapacidad.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numCapacidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCapacidad.Name = "numCapacidad";
            numCapacidad.Size = new System.Drawing.Size(60, 23);
            numCapacidad.TabIndex = 1;
            numCapacidad.Value = new decimal(new int[] { 5, 0, 0, 0 });
            //
            // btnCrear
            //
            btnCrear.Location = new System.Drawing.Point(375, 13);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new System.Drawing.Size(130, 28);
            btnCrear.TabIndex = 2;
            btnCrear.Text = "Crear con tamaño";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += new System.EventHandler(btnCrear_Click);
            //
            // btnInsertar
            //
            btnInsertar.BackColor = System.Drawing.Color.FromArgb(198, 239, 206);
            btnInsertar.Location = new System.Drawing.Point(15, 55);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new System.Drawing.Size(115, 34);
            btnInsertar.TabIndex = 3;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += new System.EventHandler(btnInsertar_Click);
            //
            // btnExtraer
            //
            btnExtraer.BackColor = System.Drawing.Color.FromArgb(255, 199, 206);
            btnExtraer.Location = new System.Drawing.Point(140, 55);
            btnExtraer.Name = "btnExtraer";
            btnExtraer.Size = new System.Drawing.Size(115, 34);
            btnExtraer.TabIndex = 4;
            btnExtraer.Text = "Extraer";
            btnExtraer.UseVisualStyleBackColor = false;
            btnExtraer.Click += new System.EventHandler(btnExtraer_Click);
            //
            // btnVer
            //
            btnVer.BackColor = System.Drawing.Color.FromArgb(221, 235, 247);
            btnVer.Location = new System.Drawing.Point(265, 55);
            btnVer.Name = "btnVer";
            btnVer.Size = new System.Drawing.Size(115, 34);
            btnVer.TabIndex = 5;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = false;
            btnVer.Click += new System.EventHandler(btnVer_Click);
            //
            // btnEstaVacia
            //
            btnEstaVacia.Location = new System.Drawing.Point(390, 55);
            btnEstaVacia.Name = "btnEstaVacia";
            btnEstaVacia.Size = new System.Drawing.Size(115, 34);
            btnEstaVacia.TabIndex = 6;
            btnEstaVacia.Text = "isEmpty";
            btnEstaVacia.UseVisualStyleBackColor = true;
            btnEstaVacia.Click += new System.EventHandler(btnEstaVacia_Click);
            //
            // btnEstaLlena
            //
            btnEstaLlena.Location = new System.Drawing.Point(515, 55);
            btnEstaLlena.Name = "btnEstaLlena";
            btnEstaLlena.Size = new System.Drawing.Size(115, 34);
            btnEstaLlena.TabIndex = 7;
            btnEstaLlena.Text = "isFull";
            btnEstaLlena.UseVisualStyleBackColor = true;
            btnEstaLlena.Click += new System.EventHandler(btnEstaLlena_Click);
            //
            // btnReiniciar
            //
            btnReiniciar.Location = new System.Drawing.Point(640, 55);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new System.Drawing.Size(105, 34);
            btnReiniciar.TabIndex = 8;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += new System.EventHandler(btnReiniciar_Click);
            //
            // lblArreglo
            //
            lblArreglo.AutoSize = true;
            lblArreglo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblArreglo.Location = new System.Drawing.Point(15, 102);
            lblArreglo.Name = "lblArreglo";
            lblArreglo.Size = new System.Drawing.Size(150, 15);
            lblArreglo.Text = "Arreglo (estado interno):";
            //
            // lstArreglo
            //
            lstArreglo.Font = new System.Drawing.Font("Consolas", 11F);
            lstArreglo.FormattingEnabled = true;
            lstArreglo.ItemHeight = 17;
            lstArreglo.Location = new System.Drawing.Point(15, 122);
            lstArreglo.Name = "lstArreglo";
            lstArreglo.Size = new System.Drawing.Size(360, 293);
            lstArreglo.TabIndex = 9;
            //
            // lblRegistro
            //
            lblRegistro.AutoSize = true;
            lblRegistro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblRegistro.Location = new System.Drawing.Point(390, 102);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new System.Drawing.Size(125, 15);
            lblRegistro.Text = "Registro de acciones:";
            //
            // lstRegistro
            //
            lstRegistro.FormattingEnabled = true;
            lstRegistro.HorizontalScrollbar = true;
            lstRegistro.ItemHeight = 15;
            lstRegistro.Location = new System.Drawing.Point(390, 122);
            lstRegistro.Name = "lstRegistro";
            lstRegistro.Size = new System.Drawing.Size(355, 289);
            lstRegistro.TabIndex = 10;
            //
            // lblPunteros
            //
            lblPunteros.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            lblPunteros.ForeColor = System.Drawing.Color.FromArgb(31, 56, 100);
            lblPunteros.Location = new System.Drawing.Point(15, 430);
            lblPunteros.Name = "lblPunteros";
            lblPunteros.Size = new System.Drawing.Size(730, 25);
            lblPunteros.Text = "punteros";
            //
            // PanelEstructura
            //
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(lblPunteros);
            Controls.Add(lstRegistro);
            Controls.Add(lblRegistro);
            Controls.Add(lstArreglo);
            Controls.Add(lblArreglo);
            Controls.Add(btnReiniciar);
            Controls.Add(btnEstaLlena);
            Controls.Add(btnEstaVacia);
            Controls.Add(btnVer);
            Controls.Add(btnExtraer);
            Controls.Add(btnInsertar);
            Controls.Add(btnCrear);
            Controls.Add(numCapacidad);
            Controls.Add(lblTamano);
            Controls.Add(txtDato);
            Controls.Add(lblDato);
            Name = "PanelEstructura";
            Size = new System.Drawing.Size(760, 470);
            ((System.ComponentModel.ISupportInitialize)numCapacidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblDato;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Label lblTamano;
        private System.Windows.Forms.NumericUpDown numCapacidad;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnExtraer;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnEstaVacia;
        private System.Windows.Forms.Button btnEstaLlena;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label lblArreglo;
        private System.Windows.Forms.ListBox lstArreglo;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.ListBox lstRegistro;
        private System.Windows.Forms.Label lblPunteros;
    }
}
