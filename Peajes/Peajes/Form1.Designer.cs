namespace Peajes
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
            this.btnIngresarDatos = new System.Windows.Forms.Button();
            this.btnCalcularResultados = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnaNombrePeaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategoria1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCategoria2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCategoria3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaVentaTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresarDatos
            // 
            this.btnIngresarDatos.Location = new System.Drawing.Point(62, 318);
            this.btnIngresarDatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIngresarDatos.Name = "btnIngresarDatos";
            this.btnIngresarDatos.Size = new System.Drawing.Size(58, 38);
            this.btnIngresarDatos.TabIndex = 0;
            this.btnIngresarDatos.Text = "Ingresar datos\r\n";
            this.btnIngresarDatos.UseVisualStyleBackColor = true;
            this.btnIngresarDatos.Click += new System.EventHandler(this.btnIngresarDatos_Click);
            // 
            // btnCalcularResultados
            // 
            this.btnCalcularResultados.Location = new System.Drawing.Point(189, 318);
            this.btnCalcularResultados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcularResultados.Name = "btnCalcularResultados";
            this.btnCalcularResultados.Size = new System.Drawing.Size(74, 38);
            this.btnCalcularResultados.TabIndex = 1;
            this.btnCalcularResultados.Text = "Calcular Resultados";
            this.btnCalcularResultados.UseVisualStyleBackColor = true;
            this.btnCalcularResultados.Click += new System.EventHandler(this.btnCalcularResultados_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(315, 318);
            this.btnReiniciar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(59, 38);
            this.btnReiniciar.TabIndex = 2;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(454, 318);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(59, 38);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaNombrePeaje,
            this.ColumnCategoria1,
            this.ColumnaCategoria2,
            this.ColumnaCategoria3,
            this.ColumnaVentaTotal});
            this.dataGridView.Location = new System.Drawing.Point(9, 10);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(582, 292);
            this.dataGridView.TabIndex = 4;
            // 
            // ColumnaNombrePeaje
            // 
            this.ColumnaNombrePeaje.HeaderText = "Nombre Peaje";
            this.ColumnaNombrePeaje.Name = "ColumnaNombrePeaje";
            this.ColumnaNombrePeaje.ReadOnly = true;
            this.ColumnaNombrePeaje.Width = 150;
            // 
            // ColumnCategoria1
            // 
            this.ColumnCategoria1.HeaderText = "Categoria 1";
            this.ColumnCategoria1.Name = "ColumnCategoria1";
            this.ColumnCategoria1.ReadOnly = true;
            this.ColumnCategoria1.Width = 150;
            // 
            // ColumnaCategoria2
            // 
            this.ColumnaCategoria2.HeaderText = "Categoria 2";
            this.ColumnaCategoria2.Name = "ColumnaCategoria2";
            this.ColumnaCategoria2.ReadOnly = true;
            this.ColumnaCategoria2.Width = 150;
            // 
            // ColumnaCategoria3
            // 
            this.ColumnaCategoria3.HeaderText = "Categoria 3";
            this.ColumnaCategoria3.Name = "ColumnaCategoria3";
            this.ColumnaCategoria3.ReadOnly = true;
            this.ColumnaCategoria3.Width = 150;
            // 
            // ColumnaVentaTotal
            // 
            this.ColumnaVentaTotal.HeaderText = "Venta total";
            this.ColumnaVentaTotal.Name = "ColumnaVentaTotal";
            this.ColumnaVentaTotal.ReadOnly = true;
            this.ColumnaVentaTotal.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnCalcularResultados);
            this.Controls.Add(this.btnIngresarDatos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarDatos;
        private System.Windows.Forms.Button btnCalcularResultados;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNombrePeaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategoria1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCategoria2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCategoria3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaVentaTotal;
    }
}

