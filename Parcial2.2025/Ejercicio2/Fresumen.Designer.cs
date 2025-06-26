namespace Ejercicio2
{
    partial class Fresumen
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
            listbBoxPatentes = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // listbBoxPatentes
            // 
            listbBoxPatentes.FormattingEnabled = true;
            listbBoxPatentes.ItemHeight = 21;
            listbBoxPatentes.Location = new Point(15, 17);
            listbBoxPatentes.Margin = new Padding(4, 4, 4, 4);
            listbBoxPatentes.Name = "listbBoxPatentes";
            listbBoxPatentes.Size = new Size(268, 172);
            listbBoxPatentes.TabIndex = 0;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(104, 199);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(96, 32);
            button1.TabIndex = 1;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            // 
            // Fresumen
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 242);
            Controls.Add(button1);
            Controls.Add(listbBoxPatentes);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 4, 4, 4);
            Name = "Fresumen";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Fresumen";
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        public ListBox listbBoxPatentes;
    }
}