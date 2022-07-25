using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Peajes
{
    public partial class Form1 : Form
    {

        
        //Variables
        public int Peajes;
        public int Filas;
        public int[,] MatrizPejaes;
        //Vector nombre
        public string[] VNombre;
        //Matriz mejor y peor
        public string[,] MatrizMejorPeor;
        public string Mejor = "", Peor = "";



        public Form1()
        {
            InitializeComponent();
        }
        private void btnIngresarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                
                Peajes = Convert.ToInt32(Interaction.InputBox("Ingrese la cantidad de peajes"));
                dataGridView.RowCount = (Peajes + 4);
    
                //crear celdas de resultados
                dataGridView.Rows[Peajes].Cells[0].Value = "Venta Total Categoria";
                dataGridView.Rows[Peajes + 1].Cells[0].Value = "Promedio Venta Categoria";
                dataGridView.Rows[Peajes + 2].Cells[0].Value = "Mejor Peaje";
                dataGridView.Rows[Peajes + 3].Cells[0].Value = "Peor peaje";

                //agregar color a celdas derechas
                dataGridView.Rows[Peajes].Cells[0].Style.BackColor = Color.Aquamarine;
                dataGridView.Rows[Peajes + 1].Cells[0].Style.BackColor = Color.Aquamarine;
                dataGridView.Rows[Peajes + 2].Cells[0].Style.BackColor = Color.Aquamarine;
                dataGridView.Rows[Peajes + 3].Cells[0].Style.BackColor = Color.Aquamarine;


                //agregar color a celdas izquierdas
                dataGridView.Rows[Peajes].Cells[4].Style.BackColor = Color.Gray;
                dataGridView.Rows[Peajes + 1].Cells[4].Style.BackColor = Color.Gray;
                dataGridView.Rows[Peajes + 2].Cells[4].Style.BackColor = Color.Gray;
                dataGridView.Rows[Peajes + 3].Cells[4].Style.BackColor = Color.Gray;

                //darle tamaño a la matriz   filas    colum
                MatrizPejaes = new int[(Peajes + 4), 4];

                //Vector nombre
                 VNombre = new String[Peajes];

                //ingresar los datos a los inputs
                for ( Filas = 0; Filas < Peajes; Filas++) {

                    VNombre[Filas] = Interaction.InputBox("Ingrese el Nombre del Peaje");
                    dataGridView.Rows[Filas].Cells[0].Value = VNombre[Filas];
                    MatrizPejaes[Filas, 0] = Convert.ToInt32(Interaction.InputBox("Ingrese la cantidad de peajes para la categoria 1"));
                    dataGridView.Rows[Filas].Cells[1].Value = String.Format("{0:#,0.0}", MatrizPejaes[Filas, 0]);
                    MatrizPejaes[Filas, 1] = Convert.ToInt32(Interaction.InputBox("Ingrese la cantidad de peajes para la categoria 2"));
                    dataGridView.Rows[Filas].Cells[2].Value = String.Format("{0:#,0.0}", MatrizPejaes[Filas, 1]);
                    MatrizPejaes[Filas, 2] = Convert.ToInt32(Interaction.InputBox("Ingrese la cantidad de peajes para la categoria 3"));
                    dataGridView.Rows[Filas].Cells[3].Value = String.Format("{0:#,0.0}", MatrizPejaes[Filas, 2]);
                    
                    //venta total peajes
                    MatrizPejaes[Filas, 3] = ((MatrizPejaes[Filas, 0] * 8000) + (MatrizPejaes[Filas, 1] * 10500) + (MatrizPejaes[Filas, 2] * 15000));
                    dataGridView.Rows[Filas].Cells[4].Value = String.Format("{0:$,0.0}", MatrizPejaes[Filas, 3]);


                    btnCalcularResultados.Enabled = true;
                    btnIngresarDatos.Enabled = false;
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("Error al ingresar datos, favor verificar");
                dataGridView.RowCount = 0;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Salir = MessageBox.Show("Desea Salir (Si/No) ?", "Salir Aplicación", MessageBoxButtons.YesNo);
            if (Salir == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            dataGridView.RowCount = 0;
            btnReiniciar.Enabled = false;
            btnIngresarDatos.Enabled = true;
        }

        private void btnCalcularResultados_Click(object sender, EventArgs e)
        {
            int Columnas;
            int AcumuladorVTC = 0;
            MatrizMejorPeor = new string[Peajes, 3];
            int valorCategoria = 0;

            for (Columnas = 0; Columnas <= 2; Columnas++)
            {
                for (Filas = 0; Filas < Peajes; Filas++) {
                    AcumuladorVTC = AcumuladorVTC + MatrizPejaes[Filas, Columnas];

                    //comparar valor categoria
                    if(Columnas == 0)
                    {
                        valorCategoria = 8000;
                    }
                    else if(Columnas == 1){
                        valorCategoria = 10500;
                    }
                    else{
                        valorCategoria = 15000;
                    }

                    //peor y mejor
                    if (Filas == 0)
                    {
                        Mejor = VNombre[Filas];
                        Peor = VNombre[Filas];

                    }
                    else {
                        if (MatrizPejaes[Filas,Columnas] > valorCategoria) {
                            valorCategoria = MatrizPejaes[Filas, Columnas];
                            Mejor  = VNombre[Filas];
                        } else {
                            if (MatrizPejaes[Filas,Columnas] < valorCategoria) {
                                valorCategoria = MatrizPejaes[Filas, Columnas];
                                Peor = VNombre[Filas];
                            }
                        }
                    }
                }
                //total categoria
                MatrizPejaes[Peajes, Columnas] = AcumuladorVTC ;
                dataGridView.Rows[Peajes].Cells[Columnas+1].Value = String.Format("{0:$,0.0}", MatrizPejaes[Peajes, Columnas]);

                //promedio categoria
                MatrizPejaes[(Peajes + 1),Columnas] = AcumuladorVTC / Peajes;
                dataGridView.Rows[Peajes + 1].Cells[Columnas + 1 ].Value = String.Format("{0:$,0.0}", MatrizPejaes[(Peajes + 1), Columnas]);

                //mejor
                MatrizMejorPeor[0, Columnas] = Mejor;
                dataGridView.Rows[Peajes + 2].Cells[Columnas + 1].Value = MatrizMejorPeor[0, Columnas];

                //menor
                MatrizMejorPeor[1, Columnas] = Peor;
                dataGridView.Rows[Peajes + 3].Cells[Columnas + 1].Value = MatrizMejorPeor[1, Columnas];

                //reinicar el acumulador
                AcumuladorVTC = 0;
            }
            btnIngresarDatos.Enabled = true;
            btnCalcularResultados.Enabled = false;
        }
    }
}
