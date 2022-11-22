using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP4
{
    public partial class frmTriatlon : Form
    {
        public struct DATOS
        {
            public int participante;
            public int puntos;
        }

        public frmTriatlon()
        {
            InitializeComponent();
        }

        private void frmTriatlon_Load(object sender, EventArgs e)
        {
            int i;
            for (i = 1; i <= 6; i++)
            {
                dgvParticipantes.Rows.Add(i.ToString());
            }
            dgvParticipantes.Columns[0].ReadOnly = true;
            dgvPosiciones.Enabled = false;

        }

        private void btnAsignarParticipantes_Click(object sender, EventArgs e)
        {
            int i;
            dgvPosiciones.Rows.Clear();
            for (i = 0; i < 6; i++)
            {
                if (dgvParticipantes.Rows[i].Cells[1].Value == null ||
                dgvParticipantes.Rows[i].Cells[2].Value == null)
                {
                    MessageBox.Show("Debe completar los datos de todos los participantes",
                    "Error", MessageBoxButtons.OK);
                    return;
                }
            }
            for (i = 0; i < 6; i++)
            {
                dgvPosiciones.Columns[i + 1].HeaderText =
                dgvParticipantes.Rows[i].Cells[1].Value.ToString();
            }
            for (i = 0; i < 3; i++)
            {
                dgvPosiciones.Rows.Add();
            }
            dgvPosiciones.Rows[0].Cells[0].Value = "Natación";
            dgvPosiciones.Rows[1].Cells[0].Value = "Ciclismo";
            dgvPosiciones.Rows[2].Cells[0].Value = "Carrera";
            dgvPosiciones.Columns[0].ReadOnly = true;
            dgvParticipantes.ClearSelection();
            dgvPosiciones.Enabled = true;
        }

        private void btnDeterminarGanadores_Click(object sender, EventArgs e)
        {
            int fila;
            int col;
            int i;
            string valor;
            string nombre;
            string nacionalidad;
            if (!ValidarPosiciones())
            {
                MessageBox.Show("Los datos son incorrectos, revise las posiciones asignadas",
                "Error", MessageBoxButtons.OK);
                return;
            }
            dgvPosiciones.ClearSelection();
            int[,] puestos = new int[3, 6];
            for (fila = 0; fila < 3; fila++) 
            {
                for (col = 0; col < 6; col++) 
                {
                    valor = dgvPosiciones.Rows[fila].Cells[col + 1].Value.ToString();
                    puestos[fila, col] = int.Parse(valor); 
                }
            }
            DATOS[] datos = new DATOS[6];
            for (i = 0; i < 6; i++)
            {
                datos[i].participante = i + 1; 
                datos[i].puntos = 0;
            }
            for (col = 0; col < 6; col++) 
            {
                for (fila = 0; fila < 3; fila++)
                {
                    datos[col].puntos += ObtenerPuntos(puestos[fila, col]);
                }
            }
            DATOS[] ganadores = new DATOS[3];
            ganadores[0] = BuscarMayorPuntaje(datos, ganadores);
            ganadores[1] = BuscarMayorPuntaje(datos, ganadores);
            ganadores[2] = BuscarMayorPuntaje(datos, ganadores);
            dgvGanadores.Rows.Clear();
            for (fila = 0; fila < 3; fila++)
            {
                dgvGanadores.Rows.Add();
                dgvGanadores.Rows[fila].Cells[0].Value = fila + 1; 
                int f = ganadores[fila].participante - 1;
                nombre = dgvParticipantes.Rows[f].Cells[1].Value.ToString();
                dgvGanadores.Rows[fila].Cells[1].Value = nombre;
                nacionalidad = dgvParticipantes.Rows[f].Cells[2].Value.ToString();
                dgvGanadores.Rows[fila].Cells[2].Value = nacionalidad;
                dgvGanadores.Rows[fila].Cells[3].Value = ganadores[fila].puntos.ToString();
            }
            dgvGanadores.ClearSelection();
        }


        private bool ValidarPosiciones()
        {
            int f;
            int c;
            int i;
            int valor;
            bool resultado = true;
            for (f = 0; f < dgvPosiciones.RowCount; f++) 
            {
                for (c = 1; c < dgvPosiciones.ColumnCount; c++) 
                {
                    valor = int.Parse(dgvPosiciones.Rows[f].Cells[c].Value.ToString());
                    if (valor < 1 || valor > 6) 
                    {
                        resultado = false;
                        break;
                    }
                    for (i = c + 1; i < dgvPosiciones.ColumnCount; i++)
                    {
                        if (valor == int.Parse(dgvPosiciones.Rows[f].Cells[i].Value.ToString()))
                        {
                            resultado = false;
                            break;
                        }
                    }
                }
            }
            return resultado;
        }

        private int ObtenerPuntos(int puesto)
        {
            int[] puntos = new int[6] { 1000, 920, 830, 740, 650, 560 };
            return puntos[puesto - 1];
        }

        private DATOS BuscarMayorPuntaje(DATOS[] d, DATOS[] g)
        {
            DATOS resultado;
            int i;
            int f;
            int ganadorPrevio;
            resultado.participante = 0;
            resultado.puntos = 0;
            for (i = 0; i < 6; i++)
            {
                if (d[i].puntos > resultado.puntos)
                {
                    ganadorPrevio = 0;
                    for (f = 0; f < g.Length; f++) 
                    {
                        if (d[i].participante == g[f].participante)
                        {
                            ganadorPrevio = 1;
                        }
                    }
                    if (ganadorPrevio == 0)
                    {
                        resultado.puntos = d[i].puntos;
                        resultado.participante = d[i].participante;
                    }
                }
            }
            return resultado;
        }

        private void EscribirGanadores()
        {
            int ancho = picGanadores.Width;
            int alto = picGanadores.Height;
            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;
            Graphics gra = picGanadores.CreateGraphics();
            string nombre = dgvGanadores.Rows[0].Cells[1].Value.ToString();
            gra.DrawString(nombre, new Font("Arial", 9), Brushes.Blue,
            (ancho / 2), alto / 4, formato);
            nombre = dgvGanadores.Rows[1].Cells[1].Value.ToString();
            gra.DrawString(nombre, new Font("Arial", 9), Brushes.Blue,
            (ancho / 4), alto / 2.75f, formato);
            nombre = dgvGanadores.Rows[2].Cells[1].Value.ToString();
            gra.DrawString(nombre, new Font("Arial", 9), Brushes.Blue,
            (ancho / 1.33f), alto / 2, formato);
        }

        private void picGanadores_Click(object sender, EventArgs e)
        {
            EscribirGanadores();
        }
    }
}
    

