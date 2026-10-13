namespace AulaWindowsForm1;

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
        this.components = new System.ComponentModel.Container();
        this.label1 = new System.Windows.Forms.Label();
        this.txtNomeUsuario = new System.Windows.Forms.TextBox();
        this.label2 = new System.Windows.Forms.Label();
        this.txtSenha = new System.Windows.Forms.TextBox();
        this.btnEntrar = new System.Windows.Forms.Button();
        this.btnCadastrar = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(10, 13);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(38, 15);
        this.label1.TabIndex = 0;
        this.label1.Text = "Usuário:";
        //this.label1.Click += new System.EventHandler(this.label1_Click);
        // 
        // txtNomeUsuario
        // 
        this.txtNomeUsuario.Location = new System.Drawing.Point(39, 10);
        this.txtNomeUsuario.Name = "txtNomeUsuario";
        this.txtNomeUsuario.Size = new System.Drawing.Size(100, 23);
        this.txtNomeUsuario.TabIndex = 1;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(10, 29);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(38, 15);
        this.label2.TabIndex = 2;
        this.label2.Text = "Senha:";
        // 
        // txtSenha
        // 
        this.txtSenha.Location = new System.Drawing.Point(38, 26);
        this.txtSenha.Name = "txtSenha";
        this.txtSenha.Size = new System.Drawing.Size(100, 23);
        this.txtSenha.TabIndex = 3;
        this.txtSenha.PasswordChar = '*';
        // 
        // button1
        // 
        this.btnEntrar.Location = new System.Drawing.Point(38, 45);
        this.btnEntrar.Name = "btnEntrar";
        this.btnEntrar.Size = new System.Drawing.Size(64, 12);
        this.btnEntrar.TabIndex = 4;
        this.btnEntrar.Text = "Entrar";
        this.btnEntrar.UseVisualStyleBackColor = true;
        this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
        // 
        // button2
        // 
        this.btnCadastrar.Location = new System.Drawing.Point(116, 45);
        this.btnCadastrar.Name = "btnCadastrar";
        this.btnCadastrar.Size = new System.Drawing.Size(64, 12);
        this.btnCadastrar.TabIndex = 5;
        this.btnCadastrar.Text = "Cadastrar-se";
        this.btnCadastrar.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.btnCadastrar);
        this.Controls.Add(this.btnEntrar);
        this.Controls.Add(this.txtSenha);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.txtNomeUsuario);
        this.Controls.Add(this.label1);
        this.Name = "Form1";
        this.Text = "Form1";
        //this.Load += new System.EventHandler(this.Form1_Load);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtNomeUsuario;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtSenha;
    private System.Windows.Forms.Button btnEntrar;
    private System.Windows.Forms.Button btnCadastrar;
}
