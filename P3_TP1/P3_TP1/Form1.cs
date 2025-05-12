namespace P3_TP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            Form2 formulario2 = new Form2(this);
            formulario2.Show();
            this.Hide();
        }

        private void btnEjercicio2_Click(object sender, EventArgs e)
        {
            Form3 formulario3 = new Form3(this);
            formulario3.Show();
            this.Hide();
        }
    }
}
