using System.Xml.Serialization;
public class ArquivoXML : Arquivo
{
    public override string Escrever()
    {
        Book book = new Book() { title = "Harry Potter 1" };
        // Prepara objeto serializador:
        XmlSerializer writer = new XmlSerializer(typeof(book));
        Caminho = Environment.GetFolderPath
            (Environment.SpecialFolder.MyDocuments) + "\\livro.xml";
        FileStream arquivoXML = File.Create(Caminho);
        // Realiza a serialização e gravação no disco:
        writer.Serialize(arquivoXML, book);
        arquivoXML.Close();
        return Caminho;
    }

    public override void Ler()
    {
        try
        {
            // Prepara objeto serializador:
            XmlSerializer reader = new XmlSerializer(typeof(Book));
            //Prepara o arquivo XML
            Caminho = Environment.GetFolderPath
                (Environment.SpecialFolder.MyDocuments) + "\\livro.xml";
            StreamReader arquivoXML = new StreamReader(Caminho);
            // Deserialização do XML para objeto:
            Book book = (Book)reader.Deserialize(arquivoXML);
            Console.WriteLine($"Livro: {book.title}");
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
}