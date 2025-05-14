class Program
{
    static void Main()
    {
        int numero = ReadInt("Digite um número inteiro não-negativo: ");

        bool pertence = IsFibonacci(numero);

        Console.WriteLine(pertence
            ? $"O número {numero} pertence à sequência de Fibonacci."
            : $"O número {numero} NÃO pertence à sequência de Fibonacci.");
    }

    static int ReadInt(string prompt)
    {
        int value;
        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine()?.Trim();
            if (int.TryParse(input, out value) && value >= 0)
                return value;
            Console.WriteLine("Entrada inválida. Digite um número inteiro não-negativo.");
        } while (true);
    }

    static bool IsFibonacci(int n)
    {
        long a = 0, b = 1;
        while (b < n)
        {
            long temp = b;
            b = a + b;
            a = temp;
        }
        return b == n;
    }
}