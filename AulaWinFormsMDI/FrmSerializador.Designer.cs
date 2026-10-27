namespace AulaWinFormsMDI
{
    partial class FrmSerializador
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
            lblNome = new Label();
            lblSobrenome = new Label();
            txtNome = new TextBox();
            txtSobrenome = new TextBox();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(100, 44);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(113, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "Primeiro Nome:";
            // 
            // lblSobrenome
            // 
            lblSobrenome.AutoSize = true;
            lblSobrenome.Location = new Point(100, 98);
            lblSobrenome.Name = "lblSobrenome";
            lblSobrenome.Size = new Size(89, 20);
            lblSobrenome.TabIndex = 1;
            lblSobrenome.Text = "Sobrenome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(219, 41);
            txtNome.MaxLength = 120;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(285, 27);
            txtNome.TabIndex = 2;
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(219, 95);
            txtSobrenome.MaxLength = 120;
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(285, 27);
            txtSobrenome.TabIndex = 3;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(219, 148);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "&Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FrmSerializador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 294);
            Controls.Add(btnSalvar);
            Controls.Add(txtSobrenome);
            Controls.Add(txtNome);
            Controls.Add(lblSobrenome);
            Controls.Add(lblNome);
            Name = "FrmSerializador";
            Text = "Serialização de Objeto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblSobrenome;
        private TextBox txtNome;
        private TextBox txtSobrenome;
        private Button btnSalvar;
    }
}