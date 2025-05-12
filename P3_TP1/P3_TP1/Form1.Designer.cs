namespace P3_TP1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEjercicio1 = new Button();
            btnEjercicio2 = new Button();
            btnEjercicio3 = new Button();
            lblIntegrantes = new Label();
            lblNombre1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // btnEjercicio1
            // 
            btnEjercicio1.Location = new Point(23, 71);
            btnEjercicio1.Name = "btnEjercicio1";
            btnEjercicio1.Size = new Size(126, 60);
            btnEjercicio1.TabIndex = 0;
            btnEjercicio1.Text = "EJERCICIO 1";
            btnEjercicio1.UseVisualStyleBackColor = true;
            btnEjercicio1.Click += btnEjercicio1_Click;
            // 
            // btnEjercicio2
            // 
            btnEjercicio2.Location = new Point(172, 71);
            btnEjercicio2.Name = "btnEjercicio2";
            btnEjercicio2.Size = new Size(126, 60);
            btnEjercicio2.TabIndex = 1;
            btnEjercicio2.Text = "EJERCICIO 2";
            btnEjercicio2.UseVisualStyleBackColor = true;
            btnEjercicio2.Click += btnEjercicio2_Click;
            // 
            // btnEjercicio3
            // 
            btnEjercicio3.Location = new Point(321, 71);
            btnEjercicio3.Name = "btnEjercicio3";
            btnEjercicio3.Size = new Size(126, 60);
            btnEjercicio3.TabIndex = 2;
            btnEjercicio3.Text = "EJERCICIO 3";
            btnEjercicio3.UseVisualStyleBackColor = true;
            // 
            // lblIntegrantes
            // 
            lblIntegrantes.AutoSize = true;
            lblIntegrantes.Font = new Font("Segoe UI", 15F);
            lblIntegrantes.Location = new Point(23, 201);
            lblIntegrantes.Name = "lblIntegrantes";
            lblIntegrantes.Size = new Size(114, 28);
            lblIntegrantes.TabIndex = 3;
            lblIntegrantes.Text = "Integrantes:";
            // 
            // lblNombre1
            // 
            lblNombre1.AutoSize = true;
            lblNombre1.Font = new Font("Segoe UI", 10F);
            lblNombre1.Location = new Point(135, 229);
            lblNombre1.Name = "lblNombre1";
            lblNombre1.Size = new Size(122, 19);
            lblNombre1.TabIndex = 4;
            lblNombre1.Text = "Gonzalo Bertolucci";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 450);
            Controls.Add(lblNombre1);
            Controls.Add(lblIntegrantes);
            Controls.Add(btnEjercicio3);
            Controls.Add(btnEjercicio2);
            Controls.Add(btnEjercicio1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEjercicio1;
        private Button btnEjercicio2;
        private Button btnEjercicio3;
        private Label lblIntegrantes;
        private Label lblNombre1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
