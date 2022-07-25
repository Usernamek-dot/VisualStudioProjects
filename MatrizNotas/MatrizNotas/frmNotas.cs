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

namespace MatrizNotas
{
    public partial class frmNotas : Form
    {

        public int N, F;
        public Double[,] MatrizNotas ;
            

        public frmNotas()
        {
            InitializeComponent();
        }

        private void frmNotas_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresarDatos_Click(object sender, EventArgs e)
        {

            try
            {
                N = Convert.ToInt32(Interaction.InputBox("Ingrese el número de Estudiantes"));

                dvgNotas.RowCount = (N + 3);
                dvgNotas.Rows[N + 1].Cells[0].Value = "Nota Mayor";
                dvgNotas.Rows[N + 2].Cells[0].Value = "Nota Menor";
                dvgNotas.Rows[N].Cells[7].Style.BackColor = Color.Transparent;
                dvgNotas.Rows[N + 1].Cells[7].Style.BackColor = Color.Transparent;
                dvgNotas.Rows[N + 2].Cells[7].Style.BackColor = Color.Transparent;
                dvgNotas.Rows[N].Cells[0].Value = "Nota Promedio";



                /*Asignar valor a la matriz**/
                MatrizNotas = new double[(N + 3), 6];


                String[] VectorNombre = new string[N];
                String[] VectorResultado = new string[N];


                /* Ciclo para asignar las columnas al datagridview**/
                for (F = 0; F < N; F++)
                {

                    /**Se asigna al la variable del ciclo un celda interactiva*/
                    VectorNombre[F] = Interaction.InputBox("Ingrese nombre del estudiante ");
                    ////Asignar el valor a la celda del data datagridview
                    dvgNotas.Rows[F].Cells[0].Value = VectorNombre[F];

                    /**Se asigna al la variable del ciclo un celda interactiva*/
                    MatrizNotas[F, 0] = Convert.ToDouble(Interaction.InputBox("Ingrese la nota 1"));
                    ////Asignar el valor a la celda del data datagridview
                    dvgNotas.Rows[F].Cells[1].Value = MatrizNotas[F, 0];

                    /**Se asigna al la variable del ciclo un celda interactiva*/
                    MatrizNotas[F, 1] = Convert.ToDouble(Interaction.InputBox("Ingrese la nota 2"));
                    ////Asignar el valor a la celda del data datagridview
                    dvgNotas.Rows[F].Cells[2].Value = MatrizNotas[F, 1];

                    /**Se asigna al la variable del ciclo un celda interactiva*/
                    MatrizNotas[F, 2] = Convert.ToDouble(Interaction.InputBox("Ingrese la nota 3"));
                    ////Asignar el valor a la celda del data datagridview
                    dvgNotas.Rows[F].Cells[3].Value = MatrizNotas[F, 2];

                    /**Se asigna al la variable del ciclo un celda interactiva*/
                    MatrizNotas[F, 3] = Convert.ToDouble(Interaction.InputBox("Ingrese la nota 4"));
                    ////Asignar el valor a la celda del data datagridview
                    dvgNotas.Rows[F].Cells[4].Value = MatrizNotas[F, 3];

                    /**Se asigna al la variable del ciclo un celda interactiva*/
                    MatrizNotas[F, 4] = Convert.ToDouble(Interaction.InputBox("Ingrese la nota 5"));
                    ////Asignar el valor a la celda del data datagridview
                    dvgNotas.Rows[F].Cells[5].Value = MatrizNotas[F, 4];


                
                    //calcular nota definitiva
                    MatrizNotas[F, 5] = (((MatrizNotas[F, 0] + MatrizNotas[F, 1] + MatrizNotas[F, 2]) / 3) * 0.4) + (MatrizNotas[F, 3] * 0.25) + (MatrizNotas[F, 4] * 0.35);
                    dvgNotas.Rows[F].Cells[6].Value = String.Format("{0:#,0.00}",MatrizNotas[F, 5]);


                    if (MatrizNotas[F, 5] >= 3.0) {
                        VectorResultado[F] = "GANA";
                        dvgNotas.Rows[F].Cells[7].Style.BackColor = Color.Blue;
                    }


                    else {
                        VectorResultado[F] = "PIERDE";
                        dvgNotas.Rows[F].Cells[7].Style.BackColor = Color.Red;
                    }
                    dvgNotas.Rows[F].Cells[7].Value = VectorResultado[F];


                    btnCalcularResultados.Enabled = true;
                    btnIngresarDatos.Enabled = false;


                }


                
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al ingresar datos,Intente de nuevo ");
                dvgNotas.RowCount = 0;

            }

        }

        private void btnCalcularResultados_Click(object sender, EventArgs e)
        {

          
                //las variables se inciializan como privadas
            int Columnas;
            double Acumulador = 0, NotaMayor = 0, NotaMenor = 0;

            for (Columnas = 0; Columnas <= 5; Columnas++) {
                for(F = 0; F<N; F++)
                {
                    Acumulador = Acumulador + MatrizNotas[F,Columnas];
                    if (F == 0)
                    {
                        NotaMayor = MatrizNotas[F, Columnas];
                        NotaMenor = MatrizNotas[F, Columnas];
                    }
                    else {
                        if (MatrizNotas[F, Columnas] > NotaMayor) {
                            NotaMayor = MatrizNotas[F, Columnas];
                        } else {

                            if (MatrizNotas[F, Columnas] < NotaMenor) {
                                NotaMenor = MatrizNotas[F, Columnas];
                            }
                        }
                    }
                }

                MatrizNotas[N, Columnas] = Acumulador / N;

                //MAYOR
                dvgNotas.Rows[N].Cells[Columnas+1].Value = String.Format("{0:#,0.00}" , MatrizNotas[N, Columnas]);
                MatrizNotas[(N + 1), Columnas] = NotaMayor;

                //MENOR
                dvgNotas.Rows[N+1].Cells[Columnas + 1].Value = String.Format("{0:#,0.00}" , MatrizNotas[(N + 1), Columnas]);
                MatrizNotas[(N + 2), Columnas] = NotaMenor;

                dvgNotas.Rows[N + 2].Cells[Columnas + 1].Value = String.Format("{0:#,0.00}", MatrizNotas[(N + 2), Columnas]);
                Acumulador = 0;


            }

            btnReiniciarProceso.Enabled = true;
            btnCalcularResultados.Enabled = false;

        }

        private void btnReiniciarProceso_Click(object sender, EventArgs e)
        {
            dvgNotas.RowCount = 0;

            btnIngresarDatos.Enabled = true;
            btnReiniciarProceso.Enabled = false;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Salir = MessageBox.Show("Desea irse del sistema ?",
                "SALIR SISTEMA", MessageBoxButtons.YesNo);
            if (Salir == DialogResult.Yes) {
                Close();
            }
        }

        private void dvgNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
