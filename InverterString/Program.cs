class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Inervsão de String:");
        Console.WriteLine("Digite uma string para inverter:");
        string input = Console.ReadLine();
        Console.WriteLine(InverterString(input));
    }

    public static string InverterString(string str)
    {
        char[] charArray = str.ToCharArray();

        for (int i = 0, j = charArray.Length - 1; i < j; i++, j--)
        {
            char temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
        }

        return new string(charArray);
    }
}