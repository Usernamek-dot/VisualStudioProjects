namespace ClubObesidad
{
    partial class frmClub
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoBascula1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoBascula2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoBascula3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoPromedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NRC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EdadSupervivencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalcularResultados = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIngresarDatos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Estatura,
            this.Edad,
            this.PesoBascula1,
            this.PesoBascula2,
            this.PesoBascula3,
            this.PesoPromedio,
            this.IMC,
            this.NRC,
            this.EdadSupervivencia});
            this.dataGridView.Location = new System.Drawing.Point(0, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1131, 326);
            this.dataGridView.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Estatura
            // 
            this.Estatura.HeaderText = "Estatura";
            this.Estatura.Name = "Estatura";
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            // 
            // PesoBascula1
            // 
            this.PesoBascula1.HeaderText = "Peso Bascula1";
            this.PesoBascula1.Name = "PesoBascula1";
            // 
            // PesoBascula2
            // 
            this.PesoBascula2.HeaderText = "Peso Bascula2";
            this.PesoBascula2.Name = "PesoBascula2";
            // 
            // PesoBascula3
            // 
            this.PesoBascula3.HeaderText = "Peso Bascula3";
            this.PesoBascula3.Name = "PesoBascula3";
            // 
            // PesoPromedio
            // 
            this.PesoPromedio.HeaderText = "Peso Promedio";
            this.PesoPromedio.Name = "PesoPromedio";
            this.PesoPromedio.Width = 150;
            // 
            // IMC
            // 
            this.IMC.HeaderText = "IMC";
            this.IMC.Name = "IMC";
            // 
            // NRC
            // 
            this.NRC.HeaderText = "NRC";
            this.NRC.Name = "NRC";
            // 
            // EdadSupervivencia
            // 
            this.EdadSupervivencia.HeaderText = "ES";
            this.EdadSupervivencia.Name = "EdadSupervivencia";
            this.EdadSupervivencia.Width = 150;
            // 
            // btnCalcularResultados
            // 
            this.btnCalcularResultados.Location = new System.Drawing.Point(505, 385);
            this.btnCalcularResultados.Name = "btnCalcularResultados";
            this.btnCalcularResultados.Size = new System.Drawing.Size(110, 53);
            this.btnCalcularResultados.TabIndex = 1;
            this.btnCalcularResultados.Text = "Resultados";
            this.btnCalcularResultados.UseVisualStyleBackColor = true;
            this.btnCalcularResultados.Click += new System.EventHandler(this.btnCalcularResultados_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(818, 385);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 53);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnIngresarDatos
            // 
            this.btnIngresarDatos.Location = new System.Drawing.Point(192, 385);
            this.btnIngresarDatos.Name = "btnIngresarDatos";
            this.btnIngresarDatos.Size = new System.Drawing.Size(85, 53);
            this.btnIngresarDatos.TabIndex = 3;
            this.btnIngresarDatos.Text = "Ingresar datos";
            this.btnIngresarDatos.UseVisualStyleBackColor = true;
            this.btnIngresarDatos.Click += new System.EventHandler(this.btnIngresarDatos_Click);
            // 
            // frmClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 450);
            this.Controls.Add(this.btnIngresarDatos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcularResultados);
            this.Controls.Add(this.dataGridView);
            this.Name = "frmClub";
            this.Text = "Averigue su peso";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnCalcularResultados;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnIngresarDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoBascula1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoBascula2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoBascula3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoPromedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NRC;
        private System.Windows.Forms.DataGridViewTextBoxColumn EdadSupervivencia;
    }
}

