namespace AulaWinFormsMDI
{
    partial class FrmDesserializador
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
            lblSobrenomeTit = new Label();
            lblNomeTit = new Label();
            lblNome = new Label();
            lblSobrenome = new Label();
            btnAtualizar = new Button();
            SuspendLayout();
            // 
            // lblSobrenomeTit
            // 
            lblSobrenomeTit.AutoSize = true;
            lblSobrenomeTit.Location = new Point(65, 101);
            lblSobrenomeTit.Name = "lblSobrenomeTit";
            lblSobrenomeTit.Size = new Size(89, 20);
            lblSobrenomeTit.TabIndex = 3;
            lblSobrenomeTit.Text = "Sobrenome:";
            // 
            // lblNomeTit
            // 
            lblNomeTit.AutoSize = true;
            lblNomeTit.Location = new Point(65, 47);
            lblNomeTit.Name = "lblNomeTit";
            lblNomeTit.Size = new Size(113, 20);
            lblNomeTit.TabIndex = 2;
            lblNomeTit.Text = "Primeiro Nome:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNome.ForeColor = SystemColors.HotTrack;
            lblNome.Location = new Point(194, 47);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(51, 20);
            lblNome.TabIndex = 4;
            lblNome.Text = "label1";
            // 
            // lblSobrenome
            // 
            lblSobrenome.AutoSize = true;
            lblSobrenome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSobrenome.ForeColor = SystemColors.HotTrack;
            lblSobrenome.Location = new Point(194, 101);
            lblSobrenome.Name = "lblSobrenome";
            lblSobrenome.Size = new Size(51, 20);
            lblSobrenome.TabIndex = 5;
            lblSobrenome.Text = "label2";
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(194, 151);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(94, 29);
            btnAtualizar.TabIndex = 6;
            btnAtualizar.Text = "&Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // FrmDesserializador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 229);
            Controls.Add(btnAtualizar);
            Controls.Add(lblSobrenome);
            Controls.Add(lblNome);
            Controls.Add(lblSobrenomeTit);
            Controls.Add(lblNomeTit);
            Name = "FrmDesserializador";
            Text = "Desserialização de Objeto";
            Activated += FrmDesserializador_Activated;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSobrenomeTit;
        private Label lblNomeTit;
        private Label lblNome;
        private Label lblSobrenome;
        private Button btnAtualizar;
    }
}