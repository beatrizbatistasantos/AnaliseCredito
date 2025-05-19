decimal rendaMensal, valorEmprestimo;
int qtdParcelas;

Console.WriteLine("===== Bem-vindo à Análise de Crédito =====");

Console.Write("Digite a sua Renda Mensal em R$:");
while (!decimal.TryParse(Console.ReadLine(), out rendaMensal) || rendaMensal <= 0)
{
    Console.WriteLine("Valor inválido! Digite um valor numérico positivo para a renda mensal.");
}

Console.Write("Digite o Valor que deseja pegar emprestado em R$:");
while (!decimal.TryParse(Console.ReadLine(), out valorEmprestimo) || valorEmprestimo <= 0)
{
    Console.WriteLine("Valor inválido! Digite um valor numérico positivo para o valor do empréstimo.");
}

Console.Write("Digite em quantas parcelas deseja pagar:");
while (!int.TryParse(Console.ReadLine(), out qtdParcelas) || qtdParcelas <= 0)
{
    Console.WriteLine("Valor inválido! Digite um valor inteiro positivo para a quantidade de parcelas.");
}

decimal valorParcela = valorEmprestimo / qtdParcelas;
decimal limiteEmprestimo = rendaMensal * 0.3m;

if (valorParcela <= limiteEmprestimo)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("Parabéns! Empréstimo autorizado.");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Empréstimo negado, aumente sua renda ou solicite um valor menor!");
    Console.ResetColor();
}

Console.WriteLine();
Console.WriteLine("Aperte qualquer tecla para finalizar a aplicação...");
Console.ReadKey();
Console.Clear();