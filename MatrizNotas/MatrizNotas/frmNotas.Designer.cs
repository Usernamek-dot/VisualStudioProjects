namespace MatrizNotas
{
    partial class frmNotas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dvgNotas = new System.Windows.Forms.DataGridView();
            this.btnIngresarDatos = new System.Windows.Forms.Button();
            this.btnCalcularResultados = new System.Windows.Forms.Button();
            this.btnReiniciarProceso = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNota1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNota2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNota3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNota4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNota5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNotaDef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmResultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgNotas
            // 
            this.dvgNotas.AllowUserToAddRows = false;
            this.dvgNotas.AllowUserToDeleteRows = false;
            this.dvgNotas.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dvgNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNombre,
            this.clmNota1,
            this.clmNota2,
            this.clmNota3,
            this.clmNota4,
            this.clmNota5,
            this.clmNotaDef,
            this.clmResultado});
            this.dvgNotas.GridColor = System.Drawing.SystemColors.Info;
            this.dvgNotas.Location = new System.Drawing.Point(4, 12);
            this.dvgNotas.Name = "dvgNotas";
            this.dvgNotas.ReadOnly = true;
            this.dvgNotas.RowTemplate.Height = 24;
            this.dvgNotas.Size = new System.Drawing.Size(784, 312);
            this.dvgNotas.TabIndex = 0;
            this.dvgNotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgNotas_CellContentClick);
            // 
            // btnIngresarDatos
            // 
            this.btnIngresarDatos.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnIngresarDatos.Location = new System.Drawing.Point(122, 356);
            this.btnIngresarDatos.Name = "btnIngresarDatos";
            this.btnIngresarDatos.Size = new System.Drawing.Size(75, 50);
            this.btnIngresarDatos.TabIndex = 1;
            this.btnIngresarDatos.Text = "Ingresar Datos";
            this.btnIngresarDatos.UseVisualStyleBackColor = false;
            this.btnIngresarDatos.Click += new System.EventHandler(this.btnIngresarDatos_Click);
            // 
            // btnCalcularResultados
            // 
            this.btnCalcularResultados.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnCalcularResultados.Enabled = false;
            this.btnCalcularResultados.Location = new System.Drawing.Point(278, 351);
            this.btnCalcularResultados.Name = "btnCalcularResultados";
            this.btnCalcularResultados.Size = new System.Drawing.Size(94, 60);
            this.btnCalcularResultados.TabIndex = 2;
            this.btnCalcularResultados.Text = "Calcular Resultados";
            this.btnCalcularResultados.UseVisualStyleBackColor = false;
            this.btnCalcularResultados.Click += new System.EventHandler(this.btnCalcularResultados_Click);
            // 
            // btnReiniciarProceso
            // 
            this.btnReiniciarProceso.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnReiniciarProceso.Enabled = false;
            this.btnReiniciarProceso.Location = new System.Drawing.Point(438, 351);
            this.btnReiniciarProceso.Name = "btnReiniciarProceso";
            this.btnReiniciarProceso.Size = new System.Drawing.Size(96, 60);
            this.btnReiniciarProceso.TabIndex = 3;
            this.btnReiniciarProceso.Text = "Reiniciar Proceso";
            this.btnReiniciarProceso.UseVisualStyleBackColor = false;
            this.btnReiniciarProceso.Click += new System.EventHandler(this.btnReiniciarProceso_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnSalir.Location = new System.Drawing.Point(596, 356);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 50);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // clmNombre
            // 
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            this.clmNombre.Width = 80;
            // 
            // clmNota1
            // 
            this.clmNota1.HeaderText = "Nota1";
            this.clmNota1.Name = "clmNota1";
            this.clmNota1.ReadOnly = true;
            this.clmNota1.Width = 70;
            // 
            // clmNota2
            // 
            this.clmNota2.HeaderText = "Nota2";
            this.clmNota2.Name = "clmNota2";
            this.clmNota2.ReadOnly = true;
            this.clmNota2.Width = 70;
            // 
            // clmNota3
            // 
            this.clmNota3.HeaderText = "Nota3";
            this.clmNota3.Name = "clmNota3";
            this.clmNota3.ReadOnly = true;
            this.clmNota3.Width = 70;
            // 
            // clmNota4
            // 
            this.clmNota4.HeaderText = "Nota4";
            this.clmNota4.Name = "clmNota4";
            this.clmNota4.ReadOnly = true;
            this.clmNota4.Width = 70;
            // 
            // clmNota5
            // 
            this.clmNota5.HeaderText = "Nota5";
            this.clmNota5.Name = "clmNota5";
            this.clmNota5.ReadOnly = true;
            this.clmNota5.Width = 70;
            // 
            // clmNotaDef
            // 
            this.clmNotaDef.HeaderText = "Nota Definitiva";
            this.clmNotaDef.Name = "clmNotaDef";
            this.clmNotaDef.ReadOnly = true;
            // 
            // clmResultado
            // 
            this.clmResultado.HeaderText = "Resultado";
            this.clmResultado.Name = "clmResultado";
            this.clmResultado.ReadOnly = true;
            // 
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReiniciarProceso);
            this.Controls.Add(this.btnCalcularResultados);
            this.Controls.Add(this.btnIngresarDatos);
            this.Controls.Add(this.dvgNotas);
            this.Name = "frmNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgNotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgNotas;
        private System.Windows.Forms.Button btnIngresarDatos;
        private System.Windows.Forms.Button btnCalcularResultados;
        private System.Windows.Forms.Button btnReiniciarProceso;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNota1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNota2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNota3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNota4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNota5;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNotaDef;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmResultado;
    }
}

