namespace P3_TP1
{
    partial class Form3
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
            gbDatos = new GroupBox();
            btnAgregar = new Button();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            lblApellido = new Label();
            lblNombre = new Label();
            gbElementos = new GroupBox();
            btnBorrar = new Button();
            lbElementos = new ListBox();
            gbDatos.SuspendLayout();
            gbElementos.SuspendLayout();
            SuspendLayout();
            // 
            // gbDatos
            // 
            gbDatos.Controls.Add(btnAgregar);
            gbDatos.Controls.Add(txtApellido);
            gbDatos.Controls.Add(txtNombre);
            gbDatos.Controls.Add(lblApellido);
            gbDatos.Controls.Add(lblNombre);
            gbDatos.Location = new Point(12, 48);
            gbDatos.Name = "gbDatos";
            gbDatos.Size = new Size(255, 423);
            gbDatos.TabIndex = 1;
            gbDatos.TabStop = false;
            gbDatos.Text = "Ingreso de Datos";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAgregar.Location = new Point(83, 273);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(83, 31);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(103, 208);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(146, 23);
            txtApellido.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(103, 161);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(146, 23);
            txtNombre.TabIndex = 2;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblApellido.Location = new Point(9, 206);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(91, 25);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(6, 159);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(91, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // gbElementos
            // 
            gbElementos.Controls.Add(btnBorrar);
            gbElementos.Controls.Add(lbElementos);
            gbElementos.Location = new Point(291, 48);
            gbElementos.Name = "gbElementos";
            gbElementos.Size = new Size(255, 423);
            gbElementos.TabIndex = 2;
            gbElementos.TabStop = false;
            gbElementos.Text = "Elementos";
            // 
            // btnBorrar
            // 
            btnBorrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBorrar.Location = new Point(94, 370);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 31);
            btnBorrar.TabIndex = 1;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // lbElementos
            // 
            lbElementos.FormattingEnabled = true;
            lbElementos.ItemHeight = 15;
            lbElementos.Location = new Point(10, 34);
            lbElementos.Name = "lbElementos";
            lbElementos.Size = new Size(239, 319);
            lbElementos.TabIndex = 0;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 483);
            Controls.Add(gbElementos);
            Controls.Add(gbDatos);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            FormClosed += Form3_FormClosed;
            Load += Form3_Load;
            gbDatos.ResumeLayout(false);
            gbDatos.PerformLayout();
            gbElementos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbDatos;
        private Label lblNombre;
        private GroupBox gbElementos;
        private Button btnAgregar;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label lblApellido;
        private Button btnBorrar;
        private ListBox lbElementos;
    }
}