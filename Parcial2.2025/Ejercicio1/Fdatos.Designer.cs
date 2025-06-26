namespace Ejercicio1
{
    partial class Fdatos
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
            label1 = new Label();
            label2 = new Label();
            tbPatente = new TextBox();
            tbKilometros = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 48);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 21);
            label1.TabIndex = 0;
            label1.Text = "Nro Patente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 101);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 1;
            label2.Text = "Kilometraje";
            // 
            // tbPatente
            // 
            tbPatente.BorderStyle = BorderStyle.FixedSingle;
            tbPatente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPatente.Location = new Point(179, 46);
            tbPatente.Margin = new Padding(4, 4, 4, 4);
            tbPatente.Name = "tbPatente";
            tbPatente.Size = new Size(128, 29);
            tbPatente.TabIndex = 2;
            // 
            // tbKilometros
            // 
            tbKilometros.Location = new Point(179, 98);
            tbKilometros.Margin = new Padding(4, 4, 4, 4);
            tbKilometros.Name = "tbKilometros";
            tbKilometros.Size = new Size(127, 29);
            tbKilometros.TabIndex = 3;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(111, 168);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(96, 32);
            button1.TabIndex = 4;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(249, 168);
            button2.Margin = new Padding(4, 4, 4, 4);
            button2.Name = "button2";
            button2.Size = new Size(96, 32);
            button2.TabIndex = 5;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // Fdatos
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 223);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tbKilometros);
            Controls.Add(tbPatente);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 4, 4, 4);
            Name = "Fdatos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Fdatos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        public TextBox tbPatente;
        public TextBox tbKilometros;
        private Button button1;
        private Button button2;
    }
}