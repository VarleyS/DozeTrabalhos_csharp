namespace Verifica_Caractere
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
            Label = new Label();
            txtCaractere = new TextBox();
            btnVerifica = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Location = new Point(334, 84);
            Label.Name = "Label";
            Label.Size = new Size(112, 15);
            Label.TabIndex = 0;
            Label.Text = "Informe o Caractere";
            // 
            // txtCaractere
            // 
            txtCaractere.Location = new Point(284, 140);
            txtCaractere.Name = "txtCaractere";
            txtCaractere.Size = new Size(203, 23);
            txtCaractere.TabIndex = 1;
            // 
            // btnVerifica
            // 
            btnVerifica.Location = new Point(319, 223);
            btnVerifica.Name = "btnVerifica";
            btnVerifica.Size = new Size(141, 54);
            btnVerifica.TabIndex = 2;
            btnVerifica.Text = "Verifica";
            btnVerifica.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(319, 324);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(128, 50);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "retorno";
            lblResultado.UseCompatibleTextRendering = true;
            lblResultado.Visible = false;
            lblResultado.TextChanged += BtnVerifica;
            lblResultado.Click += Form1_Load;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnVerifica);
            Controls.Add(txtCaractere);
            Controls.Add(Label);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCaractere;
        private Label Label;
        private Button btnVerifica;
        private Label lblResultado;
    }
}
