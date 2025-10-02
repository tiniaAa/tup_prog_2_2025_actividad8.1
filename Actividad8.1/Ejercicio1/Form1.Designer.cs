namespace Ejercicio1
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
            Nombre = new Label();
            label2 = new Label();
            label3 = new Label();
            tbNombre = new TextBox();
            tbImporte = new TextBox();
            tbDNI = new TextBox();
            btnConfirmar = new Button();
            listBox1 = new ListBox();
            btnActualizar = new Button();
            SuspendLayout();
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(12, 15);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(64, 20);
            Nombre.TabIndex = 0;
            Nombre.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 1;
            label2.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 104);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 2;
            label3.Text = "Importe";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(106, 8);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(125, 27);
            tbNombre.TabIndex = 3;
            // 
            // tbImporte
            // 
            tbImporte.Location = new Point(106, 101);
            tbImporte.Name = "tbImporte";
            tbImporte.Size = new Size(125, 27);
            tbImporte.TabIndex = 4;
            // 
            // tbDNI
            // 
            tbDNI.Location = new Point(106, 53);
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(125, 27);
            tbDNI.TabIndex = 5;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(297, 56);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(94, 29);
            btnConfirmar.TabIndex = 6;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 186);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(279, 104);
            listBox1.TabIndex = 7;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(297, 212);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 310);
            Controls.Add(btnActualizar);
            Controls.Add(listBox1);
            Controls.Add(btnConfirmar);
            Controls.Add(tbDNI);
            Controls.Add(tbImporte);
            Controls.Add(tbNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Nombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Nombre;
        private Label label2;
        private Label label3;
        private TextBox tbNombre;
        private TextBox tbImporte;
        private TextBox tbDNI;
        private Button btnConfirmar;
        private ListBox listBox1;
        private Button btnActualizar;
    }
}
