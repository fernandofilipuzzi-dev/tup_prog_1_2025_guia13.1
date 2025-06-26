namespace Ejercicio4
{
    partial class Principal
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
            btnRegistrar = new Button();
            btnCargarViaje = new Button();
            btnVer = new Button();
            btnSalir = new Button();
            listBoxPatentes = new ListBox();
            label1 = new Label();
            labelCantViajes = new Label();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(25, 27);
            btnRegistrar.Margin = new Padding(4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(96, 32);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCargarViaje
            // 
            btnCargarViaje.Location = new Point(25, 76);
            btnCargarViaje.Margin = new Padding(4);
            btnCargarViaje.Name = "btnCargarViaje";
            btnCargarViaje.Size = new Size(96, 54);
            btnCargarViaje.TabIndex = 1;
            btnCargarViaje.Text = "Cargar Viaje";
            btnCargarViaje.UseVisualStyleBackColor = true;
            btnCargarViaje.Click += btnCargarViaje_Click;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(25, 138);
            btnVer.Margin = new Padding(4);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(96, 68);
            btnVer.TabIndex = 2;
            btnVer.Text = "Resumen Final";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(25, 210);
            btnSalir.Margin = new Padding(4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(96, 32);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // listBoxPatentes
            // 
            listBoxPatentes.FormattingEnabled = true;
            listBoxPatentes.ItemHeight = 21;
            listBoxPatentes.Location = new Point(146, 13);
            listBoxPatentes.Margin = new Padding(4);
            listBoxPatentes.Name = "listBoxPatentes";
            listBoxPatentes.Size = new Size(263, 193);
            listBoxPatentes.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 210);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 21);
            label1.TabIndex = 5;
            label1.Text = "Viajes";
            // 
            // labelCantViajes
            // 
            labelCantViajes.AutoSize = true;
            labelCantViajes.Location = new Point(276, 210);
            labelCantViajes.Margin = new Padding(4, 0, 4, 0);
            labelCantViajes.Name = "labelCantViajes";
            labelCantViajes.Size = new Size(52, 21);
            labelCantViajes.TabIndex = 6;
            labelCantViajes.Text = "label2";
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 246);
            Controls.Add(labelCantViajes);
            Controls.Add(label1);
            Controls.Add(listBoxPatentes);
            Controls.Add(btnSalir);
            Controls.Add(btnVer);
            Controls.Add(btnCargarViaje);
            Controls.Add(btnRegistrar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar;
        private Button btnCargarViaje;
        private Button btnVer;
        private Button btnSalir;
        private ListBox listBoxPatentes;
        private Label label1;
        private Label labelCantViajes;
    }
}
