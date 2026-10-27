using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace AulaWinFormsMDI
{
    public partial class FrmSerializador : Form
    {
        public FrmSerializador()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SerializarObjeto();
        }

        /// <summary>
        /// Valida o preenchimento do formulário
        /// </summary>
        /// <returns></returns>
        private bool FormularioValido()
        {
            if (txtNome.Text.Trim() == String.Empty)
            {
                MessageBox.Show("O nome não pode ser vazio", "Atenção ao preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return false;
            }
            if (txtSobrenome.Text.Trim() == String.Empty)
            {
                MessageBox.Show("O sobrenome não pode ser vazio", "Atenção ao preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSobrenome.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Serializa um objeto Pessoa e armazena em arquivo XML
        /// </summary>
        private void SerializarObjeto()
        {
            if (!FormularioValido()) { return; }

            Pessoa p = new Pessoa()
            {
                Nome = txtNome.Text,
                Sobrenome = txtSobrenome.Text
            };
            // Prepara objeto serializador:
            XmlSerializer writer = new XmlSerializer(typeof(Pessoa));
            FileStream arquivoXML = File.Create("pessoa.xml");
            // Realiza a serialização e gravação no disco:
            writer.Serialize(arquivoXML, p);
            arquivoXML.Close();
            MessageBox.Show("Arquivo XML salvo com sucesso!");
        }
    }
}
