using System.Xml.Serialization;

string WriteXML()
{
    List<Book> livros = new List<Book>()
    {
        new Book(){ title = "Harry Potter 1" },
        new Book(){ title = "Harry Potter 2" },
        new Book(){ title = "Harry Potter 3" }
    };
    // Book livro = new Book()
    // {
    //     title = "Harry Potter 1"
    // };
    // Prepara objeto serializador:
    XmlSerializer writer = new XmlSerializer(typeof(List<Book>));
    var path = Environment.GetFolderPath
        (Environment.SpecialFolder.MyDocuments) + "\\livros.xml";
    FileStream arquivoXML = File.Create(path);
    // Realiza a serialização e gravação no disco:
    writer.Serialize(arquivoXML, livros);
    arquivoXML.Close();
    return path;
}

void ReadXML()
{
    try
    {
        // Prepara objeto serializador:
        XmlSerializer reader = new XmlSerializer(typeof(List<Book>));
        //Prepara o arquivo XML
        var path = Environment.GetFolderPath
            (Environment.SpecialFolder.MyDocuments) + "\\livros2.xml";
        StreamReader arquivoXML = new StreamReader(path);
        // Deserialização do XML para objeto:
        List<Book> livros = (List<Book>)reader.Deserialize(arquivoXML);
        foreach (var livro in livros)
        {
            Console.WriteLine($"Livro: {livro.title}");
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

// string caminhoDoArquivo = WriteXML();
// Console.WriteLine($"Arquivo XML criado em: {caminhoDoArquivo}");
ReadXML();
