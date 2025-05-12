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
    public partial class Form3 : Form
    {
        Form1 formulario1;
        public Form3(Form1 formulario1)
        {
            InitializeComponent();
            this.formulario1 = formulario1;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            formulario1.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim().ToUpper();
            string apellido = txtApellido.Text.Trim().ToUpper();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido))
            {
                MessageBox.Show("Debe completar los campos Nombre y Apellido para continuar", "ERROR");
                return;
            }
            else
            {
                nombre.ToUpper();
                apellido.ToUpper();
                string concatenar = nombre + " " + apellido;
                bool repetido = false;

                foreach (string persona in lbElementos.Items)
                {
                    if (persona.ToUpper() == concatenar)
                    {
                        repetido = true;
                        break;
                    }
                }
                if (repetido)
                {
                    MessageBox.Show("La persona ingresada ya existe", "ALERTA");
                }
                else
                {
                    lbElementos.Items.Add(concatenar);
                    txtNombre.Text = string.Empty;
                    txtApellido.Text = string.Empty;
                }

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lbElementos.Sorted = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (lbElementos.SelectedIndex != 1)
            {
                lbElementos.Items.RemoveAt(lbElementos.SelectedIndex);
                MessageBox.Show("Persona eliminada", "Alerta");
            }
            else
            {
                MessageBox.Show("No selecciono ningun elemento", "Alerta");
            }
        }
    }
}
