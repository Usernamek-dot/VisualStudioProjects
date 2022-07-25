using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubObesidad
{
    public partial class frmClub : Form
    {
        //Crear Variables 
        public int NumeroPersonas, Filas;
        public Double[,] MatrizPersonas;


        public frmClub()
        {
            InitializeComponent();
        }
        private void btnIngresarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                NumeroPersonas = Convert.ToInt32(Interaction.InputBox("Ingrese el número  de personas que aplicarán"));


                dataGridView.RowCount = (NumeroPersonas + 4);
                dataGridView.RowCount = (NumeroPersonas + 4);
                dataGridView.Rows[NumeroPersonas].Cells[0].Value = "Nombre";

                dataGridView.Rows[NumeroPersonas].Cells[0].Value = "Valor total";
                dataGridView.Rows[NumeroPersonas + 1].Cells[0].Value = "Valor promedio";
                dataGridView.Rows[NumeroPersonas + 2].Cells[0].Value = "Valor mayor ";
                dataGridView.Rows[NumeroPersonas + 3].Cells[0].Value = "Valor menor";
                dataGridView.Rows[NumeroPersonas].Cells[7].Style.BackColor = Color.Transparent;
                dataGridView.Rows[NumeroPersonas + 1].Cells[7].Style.BackColor = Color.Transparent;
                dataGridView.Rows[NumeroPersonas + 2].Cells[7].Style.BackColor = Color.Transparent;

                MatrizPersonas = new Double[(NumeroPersonas + 4), 10];

                //Calcular resultados
                String[] VectorNombre = new String[NumeroPersonas];
                String[] VectorNRC = new String[NumeroPersonas];
                String[] VectorES = new String[NumeroPersonas];


                for (Filas = 0; Filas < NumeroPersonas; Filas++)
                {

                    //Ingresar los datos a los inputs
                    VectorNombre[Filas] = Convert.ToString(Interaction.InputBox("Ingrese el Nombre de la persona"));
                    dataGridView.Rows[Filas].Cells[0].Value = VectorNombre[Filas];
                    MatrizPersonas[Filas, 0] = Convert.ToDouble(Interaction.InputBox("Ingrese la edad"));
                    dataGridView.Rows[Filas].Cells[1].Value = String.Format("{0:#,0.0}", MatrizPersonas[Filas, 0]);
                    MatrizPersonas[Filas, 1] = Convert.ToDouble(Interaction.InputBox("Ingrese la estatura"));
                    dataGridView.Rows[Filas].Cells[2].Value = String.Format("{0:#,0.0}", MatrizPersonas[Filas, 1]);
                    MatrizPersonas[Filas, 2] = Convert.ToDouble(Interaction.InputBox("Ingrese el peso de bascula 1"));
                    dataGridView.Rows[Filas].Cells[3].Value = String.Format("{0:#,0.0}", MatrizPersonas[Filas, 2]);
                    MatrizPersonas[Filas, 3] = Convert.ToDouble(Interaction.InputBox("Ingrese el peso de bascula 2"));
                    dataGridView.Rows[Filas].Cells[4].Value = String.Format("{0:#,0.0}", MatrizPersonas[Filas, 3]);
                    MatrizPersonas[Filas, 4] = Convert.ToDouble(Interaction.InputBox("Ingrese el peso de bascula 3"));
                    dataGridView.Rows[Filas].Cells[5].Value = String.Format("{0:#,0.0}", MatrizPersonas[Filas, 4]);

                    //peso promedio
                    MatrizPersonas[Filas, 5] = ((MatrizPersonas[Filas, 2] + MatrizPersonas[Filas, 3] + MatrizPersonas[Filas, 4]) / 3);
                    dataGridView.Rows[Filas].Cells[6].Value = String.Format("{0:#,0.00}", MatrizPersonas[Filas, 5]);
                    //imc
                    MatrizPersonas[Filas, 6] = (MatrizPersonas[Filas, 5] / (MatrizPersonas[Filas, 1] * MatrizPersonas[Filas, 1]));
                    dataGridView.Rows[Filas].Cells[7].Value = String.Format("{0:#,0.00}", MatrizPersonas[Filas, 6]);

                    //nrc

                    if (MatrizPersonas[Filas, 7] < 25)
                    {
                        VectorNRC[Filas] = "0";
                        dataGridView.Rows[Filas].Cells[8].Style.BackColor = Color.GreenYellow;
                    }
                    else if (MatrizPersonas[Filas, 7] >= 25 && MatrizPersonas[Filas, 7] <= 28)
                    {
                        VectorNRC[Filas] = "1";
                        dataGridView.Rows[Filas].Cells[9].Style.BackColor = Color.GreenYellow;
                    }
                    else if (MatrizPersonas[Filas, 7] >= 29 && MatrizPersonas[Filas, 7] <= 33)
                    {
                        VectorNRC[Filas] = "2";
                        dataGridView.Rows[Filas].Cells[10].Style.BackColor = Color.GreenYellow;
                    }
                    else if (MatrizPersonas[Filas, 7] >= 34 && MatrizPersonas[Filas, 7] <= 40)
                    {
                        VectorNRC[Filas] = "3";
                        dataGridView.Rows[Filas].Cells[11].Style.BackColor = Color.GreenYellow;
                    }
                    else
                    {
                        VectorNRC[Filas] = "4";
                        dataGridView.Rows[Filas].Cells[12].Style.BackColor = Color.GreenYellow;
                    }

                    //es

                    if (MatrizPersonas[Filas, 0] < 50 && MatrizPersonas[Filas, 7] < 2)
                    {
                        VectorES[Filas] = "80";

                    }
                    else if (MatrizPersonas[Filas, 0] < 50 && MatrizPersonas[Filas, 7] >= 2)
                    {
                        VectorES[Filas] = "70";

                    }
                    else if (MatrizPersonas[Filas, 0] >= 50 && MatrizPersonas[Filas, 7] < 3)
                    {
                        VectorES[Filas] = "65";

                    }
                    else if (MatrizPersonas[Filas, 0] >= 50 && MatrizPersonas[Filas, 7] >= 3)
                    {
                        VectorES[Filas] = "60";

                    }

                    dataGridView.Rows[Filas].Cells[9].Value = VectorNRC[Filas];
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

        private void btnCalcularResultados_Click(object sender, EventArgs e)
        {

            int Columnas;
            Double Acumulador = 0, ValorMayor = 0, ValorMenor = 0;
            for (Columnas = 0; Columnas <= 5; Columnas ++)
            {
                for (Filas = 0; Filas < NumeroPersonas; Filas ++)
                {
                    Acumulador = Acumulador + MatrizPersonas[Filas, Columnas];
                    if (Filas == 0)
                    {
                        ValorMayor = MatrizPersonas[Filas, Columnas];
                        ValorMenor = MatrizPersonas[Filas, Columnas];
                    }
                    else
                    {
                        if (MatrizPersonas[Filas, Columnas] > ValorMayor)
                        {
                            ValorMayor = MatrizPersonas[Filas, Columnas];
            }
                        else
                        {
                            if (MatrizPersonas[Filas, Columnas] < ValorMenor)
                            {
                                ValorMenor = MatrizPersonas[Filas, Columnas];
                            }
                        }
                    }
                }
                MatrizPersonas[NumeroPersonas, Columnas] = Acumulador / NumeroPersonas;
                dataGridView.Rows[NumeroPersonas].Cells[Columnas + 1].Value = String.Format("{0:#,0.00}", MatrizPersonas[NumeroPersonas, Columnas]);
                MatrizPersonas[(NumeroPersonas + 1), Columnas] = ValorMayor;
                dataGridView.Rows[NumeroPersonas + 1].Cells[Columnas + 1].Value = String.Format("{0:#,0.00}", MatrizPersonas[NumeroPersonas +1 , Columnas]);
                MatrizPersonas[(NumeroPersonas + 2), Columnas] = ValorMenor;
                dataGridView.Rows[NumeroPersonas + 2].Cells[Columnas + 1].Value = String.Format("{0:#,0.00}", MatrizPersonas[NumeroPersonas + 2, Columnas]);
                Acumulador = 0;
            }
                btnIngresarDatos.Enabled = true;
                btnCalcularResultados.Enabled = false;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            DialogResult Salir = MessageBox.Show("Desea Salir (Si/No) ?", "Salir Aplicación", MessageBoxButtons.YesNo);
            if (Salir == DialogResult.Yes)
            {
                Close();
            }
        }



    }

    internal class Interaction
    {
        internal static object InputBox(string v)
        {
            throw new NotImplementedException();
        }
    }
}


        


           


      



