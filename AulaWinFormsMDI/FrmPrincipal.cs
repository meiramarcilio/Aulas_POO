namespace AulaWinFormsMDI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void formSerializadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSerializador frm = new FrmSerializador();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Saindo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void formDesserializadortoolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDesserializador frm = new FrmDesserializador();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
