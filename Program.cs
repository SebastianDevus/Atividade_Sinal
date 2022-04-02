int numeroDigitado;

Console.WriteLine();

Console.Write("Digite um número: ");
numeroDigitado = Convert.ToInt32(Console.ReadLine());

if (numeroDigitado < 0)
{
    Console.WriteLine("O número é negativo.");
}
else if (numeroDigitado > 0)
{
    Console.WriteLine("O número é positivo.");
}
else
{
    Console.WriteLine("O número é zero.");
}

Console.WriteLine();