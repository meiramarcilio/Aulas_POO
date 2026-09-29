Console.Write("Qual tipo de Arquivo você deseja escolher? 1-Json, 2-XML: ");
int opcao = int.Parse(Console.ReadLine());
Arquivo arquivo;
switch (opcao)
{
    case 1:
        arquivo = new ArquivoJson();
        break;
    case 2:
        arquivo = new ArquivoXML();
        break;
    default:
        Console.WriteLine("Opção inválida.");
        return;
}
Console.WriteLine("Escrevendo no arquivo...");
arquivo.Escrever();
Console.WriteLine("Lendo do arquivo...");
arquivo.Ler();
