namespace AulaWinFormsMDI
{
    partial class FrmPrincipal
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
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            formSerializadorToolStripMenuItem = new ToolStripMenuItem();
            formDesserializadortoolStripMenuItem = new ToolStripMenuItem();
            separadorToolStripMenuItem = new ToolStripSeparator();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { formSerializadorToolStripMenuItem, formDesserializadortoolStripMenuItem, separadorToolStripMenuItem, sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(75, 24);
            arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // formSerializadorToolStripMenuItem
            // 
            formSerializadorToolStripMenuItem.Name = "formSerializadorToolStripMenuItem";
            formSerializadorToolStripMenuItem.Size = new Size(226, 26);
            formSerializadorToolStripMenuItem.Text = "Form &Serializador";
            formSerializadorToolStripMenuItem.Click += formSerializadorToolStripMenuItem_Click;
            // 
            // formDesserializadortoolStripMenuItem
            // 
            formDesserializadortoolStripMenuItem.Name = "formDesserializadortoolStripMenuItem";
            formDesserializadortoolStripMenuItem.Size = new Size(226, 26);
            formDesserializadortoolStripMenuItem.Text = "Form &Deserializador";
            formDesserializadortoolStripMenuItem.Click += formDesserializadortoolStripMenuItem_Click;
            // 
            // separadorToolStripMenuItem
            // 
            separadorToolStripMenuItem.Name = "separadorToolStripMenuItem";
            separadorToolStripMenuItem.Size = new Size(223, 6);
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(226, 26);
            sairToolStripMenuItem.Text = "Sai&r";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aula de WinForms com Serialização de Objetos em XML";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem formSerializadorToolStripMenuItem;
        private ToolStripSeparator separadorToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem formDesserializadortoolStripMenuItem;
    }
}
