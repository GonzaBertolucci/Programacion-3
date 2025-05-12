
namespace P3_TP1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblIngresarNombre = new Label();
            txtNombre = new TextBox();
            btnAgregar = new Button();
            lbNombreIzquierda = new ListBox();
            lbNombreDerecha = new ListBox();
            btnMoverUno = new Button();
            btnMoverTodos = new Button();
            SuspendLayout();
            // 
            // lblIngresarNombre
            // 
            lblIngresarNombre.AutoSize = true;
            lblIngresarNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIngresarNombre.Location = new Point(86, 63);
            lblIngresarNombre.Name = "lblIngresarNombre";
            lblIngresarNombre.Size = new Size(158, 21);
            lblIngresarNombre.TabIndex = 0;
            lblIngresarNombre.Text = "Ingrese un nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(250, 65);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(268, 23);
            txtNombre.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(524, 63);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAceptar_Click;
            // 
            // lbNombreIzquierda
            // 
            lbNombreIzquierda.FormattingEnabled = true;
            lbNombreIzquierda.ItemHeight = 15;
            lbNombreIzquierda.Location = new Point(86, 154);
            lbNombreIzquierda.Name = "lbNombreIzquierda";
            lbNombreIzquierda.SelectionMode = SelectionMode.MultiSimple;
            lbNombreIzquierda.Size = new Size(222, 259);
            lbNombreIzquierda.TabIndex = 3;
            // 
            // lbNombreDerecha
            // 
            lbNombreDerecha.FormattingEnabled = true;
            lbNombreDerecha.ItemHeight = 15;
            lbNombreDerecha.Location = new Point(471, 154);
            lbNombreDerecha.Name = "lbNombreDerecha";
            lbNombreDerecha.Size = new Size(222, 259);
            lbNombreDerecha.TabIndex = 4;
            // 
            // btnMoverUno
            // 
            btnMoverUno.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMoverUno.Location = new Point(357, 202);
            btnMoverUno.Name = "btnMoverUno";
            btnMoverUno.Size = new Size(75, 23);
            btnMoverUno.TabIndex = 5;
            btnMoverUno.Text = ">";
            btnMoverUno.UseVisualStyleBackColor = true;
            btnMoverUno.Click += btnMoverUno_Click;
            // 
            // btnMoverTodos
            // 
            btnMoverTodos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMoverTodos.Location = new Point(357, 320);
            btnMoverTodos.Name = "btnMoverTodos";
            btnMoverTodos.Size = new Size(75, 23);
            btnMoverTodos.TabIndex = 6;
            btnMoverTodos.Text = ">>";
            btnMoverTodos.UseVisualStyleBackColor = true;
            btnMoverTodos.Click += btnMoverTodos_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMoverTodos);
            Controls.Add(btnMoverUno);
            Controls.Add(lbNombreDerecha);
            Controls.Add(lbNombreIzquierda);
            Controls.Add(btnAgregar);
            Controls.Add(txtNombre);
            Controls.Add(lblIngresarNombre);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            FormClosed += Form2_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label lblIngresarNombre;
        private TextBox txtNombre;
        private Button btnAgregar;
        private ListBox lbNombreIzquierda;
        private ListBox lbNombreDerecha;
        private Button btnMoverUno;
        private Button btnMoverTodos;
    }
}