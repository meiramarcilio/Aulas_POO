try
{
    int a = int.Parse("2");
    int idade = -1;

    if (idade < 0)
    {
        throw new IdadeInvalidaException("Idade não pode ser negativa.");
    }
}
catch (IdadeInvalidaException ex)
{
    Console.WriteLine(ex.Message);
}
catch (FormatException ex)
{
    Console.WriteLine("Erro de formato: " + ex.Message);
}
catch (System.Exception)
{
    Console.WriteLine("Erro de sistema. Contate o administrador.");
} 
finally
{
    Console.WriteLine("Bloco finally executado.");
} 