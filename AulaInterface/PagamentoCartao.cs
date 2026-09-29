class PagamentoCartao : IPagamento
{
    public decimal ValorTransacao {get; private set;}

    public void CancelarTransacao()
    {
        Console.WriteLine("Estornando valor do cartão.");
    }

    public string ObterComprovante()
    {
        return $"Comprovante cartão {ValorTransacao:C}.";
    }

    public bool ProcessarPagamento(decimal valor)
    {
        ValorTransacao = valor;
        Console.WriteLine($"Pagamento de {valor:C} realizado com cartão.");
        return true;
    }
}