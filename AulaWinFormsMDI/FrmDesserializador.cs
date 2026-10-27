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
    public partial class FrmDesserializador : Form
    {
        public FrmDesserializador()
        {
            InitializeComponent();

            DesserializarObjeto();
        }

        void DesserializarObjeto()
        {
            try
            {
                // Prepara objeto serializador:
                XmlSerializer reader = new XmlSerializer(typeof(Pessoa));
                //Prepara o arquivo XML
                StreamReader arquivoXML = new StreamReader("pessoa.xml");
                // Deserialização do XML para objeto:
                Pessoa pessoa = (Pessoa)reader.Deserialize(arquivoXML);
                if (pessoa != null)
                {
                    lblNome.Text = pessoa.Nome;
                    lblSobrenome.Text = pessoa.Sobrenome;
                }
                else
                {
                    MessageBox.Show("Não foi possível desserializar o objeto", "Problema na desserialização", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                arquivoXML.Close();
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("Arquivo não encontrado.");
            }
            catch (Exception)
            {
                Console.WriteLine("Ocorreu um erro ao ler o arquivo.");
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            DesserializarObjeto();
        }

        private void FrmDesserializador_Activated(object sender, EventArgs e)
        {
            DesserializarObjeto();
        }
    }
}
