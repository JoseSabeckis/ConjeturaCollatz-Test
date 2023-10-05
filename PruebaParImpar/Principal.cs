﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaParImpar
{
    public partial class Principal : Form
    {
        Numero NumPrincipal;
        List<Numero> ListaPrincipal;

        public Principal()
        {
            InitializeComponent();

            NumPrincipal = new Numero();
            ListaPrincipal = new List<Numero>();

        }

        public void CargarGrilla()
        {
            DgvGrilla.DataSource = ListaPrincipal.ToList();
            FormatearGrilla(DgvGrilla);
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            Limpieza();

            long desde = (long)nudDesde.Value;
            long hasta = (long)nudHasta.Value;

            if (nudDesde.Value == 0 || nudHasta.Value == 0)
            {
                MessageBox.Show("Los Numeros Tienen Que Ser Distintos a '0'", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nudHasta.Value < nudDesde.Value)
            {
                MessageBox.Show("El Numero Hasta Tiene Que Ser Mayor a Desde", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DesactivarBotones();

            Numero aux = new Numero();

            for (long i = desde; i <= hasta; i++)
            {
                aux.Principal = $"{i}";
                aux.Num = i;
                aux.NumeroRepeticiones = 0;

                for (long x = aux.Num; x != 1;)
                {
                    if (x % 2 == 0) //par
                    {
                        x /= 2;
                        aux.NumeroRepeticiones++;
                        aux.Num = i;

                    }
                    else //impar
                    {
                        x = (x * 3) + 1;
                        aux.NumeroRepeticiones++;

                    }
                }

                aux.Final = 1;
                ListaPrincipal.Add(aux);
                CargarGrilla();
                aux = new Numero();

            }

            ActivarBotones();
        }

        public void FormatearGrilla(DataGridView grilla)
        {
            for (var i = 0; i < grilla.ColumnCount; i++)
            {
                grilla.Columns[i].Visible = false;
            }

            grilla.Columns["Principal"].Visible = true;
            grilla.Columns["Principal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["Principal"].HeaderText = @"Principal";
            grilla.Columns["Principal"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grilla.Columns["Principal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grilla.Columns["NumeroRepeticiones"].Visible = true;
            grilla.Columns["NumeroRepeticiones"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["NumeroRepeticiones"].HeaderText = @"NumRepeticiones";
            grilla.Columns["NumeroRepeticiones"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grilla.Columns["NumeroRepeticiones"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grilla.Columns["Final"].Visible = true;
            grilla.Columns["Final"].Width = 100;
            grilla.Columns["Final"].HeaderText = @"Final";
            grilla.Columns["Final"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grilla.Columns["Final"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpieza();
        }

        public void Limpieza()
        {
            ListaPrincipal = new List<Numero>();
            CargarGrilla();
        }

        public void DesactivarBotones()
        {
            btnControl.Enabled = false;
            btnLimpiar.Enabled = false;

            btnDuda.Enabled = false;

            nudDesde.Enabled = false;
            nudHasta.Enabled = false;
        }

        public void ActivarBotones()
        {
            btnControl.Enabled = true;
            btnLimpiar.Enabled = true;

            btnDuda.Enabled = true;

            nudDesde.Enabled = true;
            nudHasta.Enabled = true;
        }

        private void btnDuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El Numero: Desde Determina El Comienzo De Los Calculos,\nHasta Determina El Final,\n\n" +
                "Los Calculos Son, Si El Numero Es PAR Se DIVIDE En 2,\nSi Es IMPAR Se Multiplica Por 3 + 1\n" + "Si Divide o Multiplica Seguira Hasta Que Sea '1'\n\n" +
                "Si El Final Es '1', Pasa Al Siguiente Numero (Varia Hasta Que Numero Se Coloco),\n\n" + "|--- No Existe Un Numero Que No De Como Resultado '1' ---|" + "\n\nNumero Pasando Los MIL, Puede Congelar La PC,\n\nLuego De 8999999999999999999 en Desde y Hasta, Demora.", "Calculo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}