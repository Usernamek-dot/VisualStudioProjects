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

namespace NominaMensual
{
    public partial class Form1 : Form
    {
        //Variables
        public int  Vendedores = 3;
        public int Filas;
        public double[,] MatrizNomina;



        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresarDatos_Click(object sender, EventArgs e)
        {
            try {
                //crear celdas
                dataGridView.RowCount = (Vendedores);
                //crear celdas de resultados
                dataGridView.Rows[Vendedores].Cells[0].Value = "Valor total";
                dataGridView.Rows[Vendedores + 1].Cells[0].Value = "Valor promedio";
                dataGridView.Rows[Vendedores + 2].Cells[0].Value = "Valor mayor";
                dataGridView.Rows[Vendedores + 3].Cells[0].Value = "Valor menor";

                //darle tamaño a la matriz   filas           colum
                MatrizNomina = new Double[ (Vendedores + 4 ), 10 ];

                //Vectores
                string[] VNombre = new String[Vendedores];
                double[] VBonificacion = new Double[Vendedores];

                //asignar las celdas
                for ( Filas = 0; Filas < Vendedores; Filas++) {

                    
                    VNombre[Filas] = Convert.ToString(Interaction.inputBox("Ingrese el Nombre del Vendedor"));
                    dataGridView.Rows[Filas].Cells[0].Value = VNombre[Filas];

                    //crear input
                    MatrizNomina[Filas, 0] = Convert.ToDouble(Interaction.inputBox("Ingrese el salario basico mensual"));
                    //agregar a datagridview
                    dataGridView.Rows[Filas].Cells[1].Value = String.Format("{0:#,0.0}", MatrizNomina[Filas, 0]);

                    //crear input
                    MatrizNomina[Filas, 1] = Convert.ToDouble(Interaction.inputBox("Ingrese la cantidad de tiquetes de la categoria 1"));
                    //agregar a datagridview
                    dataGridView.Rows[Filas].Cells[2].Value = String.Format("{0:#,0.0}", MatrizNomina[Filas, 1]);


                    //crear input
                    MatrizNomina[Filas, 2] = Convert.ToDouble(Interaction.inputBox("Ingrese la cantidad de tiquetes de la categoria 2"));
                    //agregar a datagridview
                    dataGridView.Rows[Filas].Cells[3].Value = String.Format("{0:#,0.0}", MatrizNomina[Filas, 2]);

                    //crear input
                    MatrizNomina[Filas, 3] = Convert.ToDouble(Interaction.inputBox("Ingrese la cantidad de tiquetes de la categoria 3"));
                    //agregar a datagridview
                    dataGridView.Rows[Filas].Cells[4].Value = String.Format("{0:#,0.0}", MatrizNomina[Filas, 3]);

                    //TOTAL PUNTOS
                    MatrizNomina[Filas, 4] = ((MatrizNomina[Filas,1]*5)+(MatrizNomina[Filas, 1] * 7)+(MatrizNomina[Filas, 1] * 10));
                    dataGridView.Rows[Filas].Cells[5].Value = String.Format("{0:#,0.00}", MatrizNomina[Filas, 4]);

                    //VALOR BONIFICACION

                    // 0 a 10.000 
                    if (MatrizNomina[Filas, 4] <= 10000) {

                        VBonificacion[Filas] = (MatrizNomina[Filas, 0] * 0.10);
                    }
                    // 10.001 a 50.000 
                    else if (MatrizNomina[Filas, 4] >= 10001 && MatrizNomina[Filas, 4] <= 50000) {

                        VBonificacion[Filas] = (MatrizNomina[Filas, 0] * 0.12);

                    }
                    // 50.001 a 100.000
                    else if (MatrizNomina[Filas, 4] >= 50001 && MatrizNomina[Filas, 4] <= 100000)
                    {

                        VBonificacion[Filas] = (MatrizNomina[Filas, 0] * 0.15);

                    }
                    // 100.001 puntos en adelante
                    else 
                    {

                        VBonificacion[Filas] = (MatrizNomina[Filas , 0] * 0.20);

                    }

                    dataGridView.Rows[Filas].Cells[6].Value = VBonificacion[Filas];



                    //SALARIO DEVENGADO
                    MatrizNomina[Filas, 6] = (MatrizNomina[Filas, 0] +  VBonificacion[Filas]);
                    dataGridView.Rows[Filas].Cells[7].Value = String.Format("{0:#,0.00}", MatrizNomina[Filas, 6]);

                    //DEDUCCION NOMINA
                    MatrizNomina[Filas, 7] = (MatrizNomina[Filas, 6] / 0.084);
                    dataGridView.Rows[Filas].Cells[8].Value = String.Format("{0:#,0.00}", MatrizNomina[Filas, 7]);


                    //SALARIO NETO
                    MatrizNomina[Filas, 8] = (MatrizNomina[Filas, 6] - MatrizNomina[Filas, 7]);
                    dataGridView.Rows[Filas].Cells[9].Value = String.Format("{0:#,0.00}", MatrizNomina[Filas, 8]);



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

        private void btnCalcularResultados_Click(object sender, EventArgs e)
        {
            int columnas;
            Double acumulador = 0,  ValorMenor = 0, ValorMayor = 0;

            for (columnas=0; columnas <= 9; columnas++) {

                for (Filas=0; Filas< Vendedores; Filas++) {
                    //contador donde se van sumando varios resultados
                    acumulador = acumulador + MatrizNomina[Filas,columnas];

                    /* MENOR Y MAYOR
                    comparar un resultado con el otro*/
                    if (Filas == 0)
                    {

                        ValorMayor = MatrizNomina[Filas, columnas];
                        ValorMenor = MatrizNomina[Filas, columnas];
                        
;
                    }
                    else {
                        if (MatrizNomina[Filas, columnas] > ValorMayor)
                        {
                            ValorMayor = MatrizNomina[Filas, columnas];
                        }
                        else {
                            if (MatrizNomina[Filas, columnas] < ValorMenor) {
                                ValorMenor = MatrizNomina[Filas, columnas];
                            }
                        }
                    }

                }

                //mayor
                MatrizNomina[(Vendedores + 1), columnas] = ValorMayor;
                dataGridView.Rows[Vendedores + 1].Cells[columnas + 1].Value = String.Format("{0:#,0.00}", MatrizNomina[(Vendedores + 1), columnas]);

                //menor
                MatrizNomina[(Vendedores + 2), columnas] = ValorMenor;
                dataGridView.Rows[Vendedores + 2].Cells[columnas + 1].Value = String.Format("{0:#,0.00}", MatrizNomina[(Vendedores + 2), columnas]);


                /* VALOR TOTAL Y PROMEDIO*/

                //TOTAL
                MatrizNomina[Vendedores, columnas] = acumulador ;
                dataGridView.Rows[Vendedores].Cells[columnas + 1].Value = String.Format("{0:#,0.00}" , MatrizNomina[Vendedores,columnas]);


                //promedio
                MatrizNomina[Vendedores, columnas] = acumulador /  3 ;
                dataGridView.Rows[Vendedores].Cells[columnas + 1].Value = String.Format("{0:#,0.00}", MatrizNomina[Vendedores, columnas]);

               
                acumulador = 0;

            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            dataGridView.RowCount = 0;
            btnReiniciar.Enabled = false;
            btnIngresarDatos.Enabled = true;


        }
    }

    internal class Interaction
    {
        internal static object inputBox(string v)
        {
            throw new NotImplementedException();
        }
    }
}
