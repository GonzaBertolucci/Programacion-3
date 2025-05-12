using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_TP1
{
    public partial class Form2 : Form
    {
        Form1 formulario1;
        public Form2(Form1 formulario1)
        {
            InitializeComponent();
            this.formulario1 = formulario1;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            formulario1.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string personaAgregada = txtNombre.Text.Trim().ToUpper();
            bool encontrado = false;

            if (txtNombre.Text.Trim() != "")
            {
                foreach (string persona in lbNombreIzquierda.Items)
                {
                    if (persona.ToUpper() == personaAgregada.ToUpper())
                    {
                        encontrado = true;
                        break;
                    }
                }
            }

            if (!encontrado)
            {
               lbNombreIzquierda.Items.Add(personaAgregada);
                txtNombre.Clear();
            }
            else
            {
                MessageBox.Show("El nombre ya se ingreso anteriormente", "Alerta");
            }

        }

        private void btnMoverUno_Click(object sender, EventArgs e)
        {

            foreach (string seleccionado in lbNombreIzquierda.SelectedItems)
            {
                lbNombreDerecha.Items.Add(seleccionado.ToUpper());
            }
            lbNombreIzquierda.Items.Clear();
        }
    }
}
