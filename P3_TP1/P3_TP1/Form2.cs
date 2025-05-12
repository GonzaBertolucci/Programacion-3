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
            if (txtNombre.Text.Trim() != "")
            {
                string personaAgregada = txtNombre.Text.Trim().ToUpper();
                bool encontrado = false;
                foreach (string persona in lbNombreIzquierda.Items)
                {
                    if (persona.ToUpper() == personaAgregada.ToUpper())
                    {
                        encontrado = true;
                        break;
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
            else
            {
                MessageBox.Show("Debe ingresar un nombre", "Error");
            }
        }

        private void btnMoverUno_Click(object sender, EventArgs e)
        {
            
            if (lbNombreIzquierda.SelectedItem!=null)
            {
                lbNombreDerecha.Items.Add(lbNombreIzquierda.SelectedItem);
                lbNombreIzquierda.Items.Remove(lbNombreIzquierda.SelectedItem);
            }
        }

        private void btnMoverTodos_Click(object sender, EventArgs e)
        {
            if(lbNombreIzquierda.Items.Count == 0)
            {
                MessageBox.Show("La lista se encuentra vacia", "Alerta");
            }

            foreach (string seleccionado in lbNombreIzquierda.Items)
            {
                lbNombreDerecha.Items.Add(seleccionado.ToUpper());
            }
                lbNombreIzquierda.Items.Clear();
        }
    }
}
