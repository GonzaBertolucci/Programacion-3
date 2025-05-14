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
    public partial class Form4 : Form
    {
        Form1 formulario1;
        public Form4(Form1 formulario1)
        {
            InitializeComponent();
            this.formulario1 = formulario1;
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            formulario1.Show();
        }

        private void btnMostrarSeleccion_Click(object sender, EventArgs e)
        {
            
                lblTexto.Visible = true;
                if (rbFemenino.Checked)
                {
                    string selecSexo = rbFemenino.Text;
                    lblSexo.Visible = true;
                    lblSexo.Text += " " + selecSexo;
                }
                else
                {
                    string selecSexo = rbMasculino.Text;
                    lblSexo.Visible = true;
                    lblSexo.Text += " " + selecSexo;
                }

                if (rbSoltero.Checked)
                {
                    string estadoCivil = rbSoltero.Text;
                    lblEstadoCivil.Visible = true;
                    lblEstadoCivil.Text += " " + estadoCivil;
                }
                else
                {
                    string estadoCivil = rbCasado.Text;
                    lblEstadoCivil.Visible = true;
                    lblEstadoCivil.Text += " " + estadoCivil;
                }

                lblOficio.Visible = true;
                lblOficio.Text = "Oficio:";

                if (chListbox.CheckedItems.Count > 0)
                {
                    foreach (string item in chListbox.CheckedItems)
                    {
                        lblOficio.Text += $"\n -{item}\n".TrimEnd();
                    }
                }
                else
                {
                    lblOficio.Text += "\n(No selecciono ningun oficio)";
                }
        }
    }
}
