namespace AulaWindowsForm1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnEntrar_Click(object sender, System.EventArgs e)
    {
        MessageBox.Show("Bem-vindo, " + txtNomeUsuario.Text);
    }
}
