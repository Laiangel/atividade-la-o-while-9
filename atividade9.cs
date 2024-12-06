using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número para verificar se é primo: ");

        // Lê o número informado pelo usuário
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            if (numero <= 1)
            {
                Console.WriteLine($"{numero} não é primo (os números primos são maiores que 1).");
            }
            else
            {
                bool ehPrimo = VerificarPrimo(numero);
                if (ehPrimo)
                {
                    Console.WriteLine($"{numero} é um número primo.");
                }
                else
                {
                    Console.WriteLine($"{numero} não é um número primo.");
                }
            }
        }
        else
        {
            Console.WriteLine("Por favor, insira um número válido.");
        }
    }

    static bool VerificarPrimo(int numero)
    {
        int divisor = 2; // Inicia a verificação com 2
        while (divisor <= Math.Sqrt(numero)) // Só precisa verificar até a raiz quadrada do número
        {
            if (numero % divisor == 0)
            {
                return false; // Encontrou um divisor, não é primo
            }
            divisor++;
        }
        return true; // Não encontrou divisores, é primo
    }
}

