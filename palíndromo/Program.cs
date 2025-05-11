namespace Palindromo;

class Verificador
{
    static void Main()
    {
        Console.WriteLine("Digite uma palavra:");
        string palavra = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(palavra))
        {
            Console.WriteLine("Você não digitou uma palavra válida.");
            return;
        }

        string palavraFormatada = palavra.ToLower();
        string reversa = "";

        for (int i = palavraFormatada.Length - 1; i >= 0; i--)
        {
            reversa += palavraFormatada[i];
        }

        if (palavraFormatada == reversa)
        {
            Console.WriteLine("A palavra é um palíndromo!");
        }
        else
        {
            Console.WriteLine("A palavra NÃO é um palíndromo.");
        }
    }
}
