namespace VerificaCaractere
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
            Label.BackColor = SystemColors.ActiveCaption;
            Label.BorderStyle = BorderStyle.Fixed3D;
            Label.Location = new Point(324, 108);
            Label.Name = "Label";
            Label.Size = new Size(114, 17);
            Label.TabIndex = 0;
            Label.Text = "Informe o Caractere";
            // 
            // txtCaractere
            // 
            txtCaractere.Location = new Point(279, 173);
            txtCaractere.Name = "txtCaractere";
            txtCaractere.Size = new Size(194, 23);
            txtCaractere.TabIndex = 1;
            // 
            // btnVerifica
            // 
            btnVerifica.Location = new Point(293, 239);
            btnVerifica.Name = "btnVerifica";
            btnVerifica.Size = new Size(166, 38);
            btnVerifica.TabIndex = 2;
            btnVerifica.Text = "Verifica";
            btnVerifica.UseVisualStyleBackColor = true;
            btnVerifica.Click += btnVerifica_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(334, 343);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 3;
            lblResultado.TextChanged += btnVerifica_Click;
            lblResultado.Click += lblResultado_Click;
            lblResultado.Leave += btnVerifica_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnVerifica);
            Controls.Add(txtCaractere);
            Controls.Add(Label);
            Cursor = Cursors.SizeWE;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label;
        private TextBox txtCaractere;
        private Button btnVerifica;
        private Label lblResultado;
    }
}
