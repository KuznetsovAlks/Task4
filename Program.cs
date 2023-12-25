namespace Task4
{ }
internal class Program
{
    static void Main()
    {
        Task1();
        //Task2();
    }

    public static void Task1()
    {
        Console.WriteLine("Введите длинное предложение:");
        string inputSentence = Console.ReadLine();

        string[] words = SplitSentence(inputSentence);

        PrintWords(words);

        Console.ReadLine();
    }

    static string[] SplitSentence(string sentence)
    {
        string[] words = sentence.Split(' ');
        return words;
    }

    static void PrintWords(string[] words)
    {
        Console.WriteLine("Слова в предложении:");

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }


    static void Task2()
    {
        Console.WriteLine("Введите длинное предложение:");
        string inputPhrase = Console.ReadLine();

        string reversedPhrase = ReversWords(inputPhrase);

        Console.WriteLine("Предложение с обратным порядком слов: ");
        Console.WriteLine(reversedPhrase);

        Console.ReadLine();
    }

    static string ReversWords(string inputPhrase)
    {
        string[] words = SplitSentence(inputPhrase);

        Array.Reverse(words);

        string reversedPhrase = string.Join(" ", words);

        return reversedPhrase;
    }
}

