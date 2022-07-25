namespace NominaMensual
{
    partial class Form1
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
            this.ColumnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaSalarioBasicoM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCategoria1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCategoria2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCategoria3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaTotalPuntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaValorBonificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaSalarioDevengado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaDeduccionNomina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaSalarioNeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIngresarDatos = new System.Windows.Forms.Button();
            this.btnCalcularResultados = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaNombre,
            this.ColumnaSalarioBasicoM,
            this.ColumnaCategoria1,
            this.ColumnaCategoria2,
            this.ColumnaCategoria3,
            this.ColumnaTotalPuntos,
            this.ColumnaValorBonificacion,
            this.ColumnaSalarioDevengado,
            this.ColumnaDeduccionNomina,
            this.ColumnaSalarioNeto});
            this.dataGridView.Location = new System.Drawing.Point(61, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1045, 332);
            this.dataGridView.TabIndex = 0;
            // 
            // ColumnaNombre
            // 
            this.ColumnaNombre.HeaderText = "Nombre";
            this.ColumnaNombre.Name = "ColumnaNombre";
            // 
            // ColumnaSalarioBasicoM
            // 
            this.ColumnaSalarioBasicoM.HeaderText = "S B M";
            this.ColumnaSalarioBasicoM.Name = "ColumnaSalarioBasicoM";
            // 
            // ColumnaCategoria1
            // 
            this.ColumnaCategoria1.HeaderText = "Categoria1";
            this.ColumnaCategoria1.Name = "ColumnaCategoria1";
            // 
            // ColumnaCategoria2
            // 
            this.ColumnaCategoria2.HeaderText = "Categoria2";
            this.ColumnaCategoria2.Name = "ColumnaCategoria2";
            // 
            // ColumnaCategoria3
            // 
            this.ColumnaCategoria3.HeaderText = "Categoria3";
            this.ColumnaCategoria3.Name = "ColumnaCategoria3";
            // 
            // ColumnaTotalPuntos
            // 
            this.ColumnaTotalPuntos.HeaderText = "Total Puntos";
            this.ColumnaTotalPuntos.Name = "ColumnaTotalPuntos";
            // 
            // ColumnaValorBonificacion
            // 
            this.ColumnaValorBonificacion.HeaderText = "Valor Bonificacion";
            this.ColumnaValorBonificacion.Name = "ColumnaValorBonificacion";
            // 
            // ColumnaSalarioDevengado
            // 
            this.ColumnaSalarioDevengado.HeaderText = "Salario Devengado";
            this.ColumnaSalarioDevengado.Name = "ColumnaSalarioDevengado";
            // 
            // ColumnaDeduccionNomina
            // 
            this.ColumnaDeduccionNomina.HeaderText = "Deduccion de Nomina";
            this.ColumnaDeduccionNomina.Name = "ColumnaDeduccionNomina";
            // 
            // ColumnaSalarioNeto
            // 
            this.ColumnaSalarioNeto.HeaderText = "Salario Neto";
            this.ColumnaSalarioNeto.Name = "ColumnaSalarioNeto";
            // 
            // btnIngresarDatos
            // 
            this.btnIngresarDatos.Location = new System.Drawing.Point(119, 379);
            this.btnIngresarDatos.Name = "btnIngresarDatos";
            this.btnIngresarDatos.Size = new System.Drawing.Size(86, 45);
            this.btnIngresarDatos.TabIndex = 1;
            this.btnIngresarDatos.Text = "Ingresar Datos";
            this.btnIngresarDatos.UseVisualStyleBackColor = true;
            this.btnIngresarDatos.Click += new System.EventHandler(this.btnIngresarDatos_Click);
            // 
            // btnCalcularResultados
            // 
            this.btnCalcularResultados.Location = new System.Drawing.Point(362, 377);
            this.btnCalcularResultados.Name = "btnCalcularResultados";
            this.btnCalcularResultados.Size = new System.Drawing.Size(80, 48);
            this.btnCalcularResultados.TabIndex = 2;
            this.btnCalcularResultados.Text = "Calcular Resultados";
            this.btnCalcularResultados.UseVisualStyleBackColor = true;
            this.btnCalcularResultados.Click += new System.EventHandler(this.btnCalcularResultados_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(932, 379);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 48);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(584, 379);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(101, 49);
            this.btnReiniciar.TabIndex = 4;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 450);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcularResultados);
            this.Controls.Add(this.btnIngresarDatos);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnIngresarDatos;
        private System.Windows.Forms.Button btnCalcularResultados;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaSalarioBasicoM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCategoria1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCategoria2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCategoria3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaTotalPuntos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaValorBonificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaSalarioDevengado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaDeduccionNomina;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaSalarioNeto;
        private System.Windows.Forms.Button btnReiniciar;
    }
}

