using System;
Console.Write("Skriv en text: "); //    29535123p48723487597645723645
string userInput = Console.ReadLine();
List<(int, int)> startAndEndIndex = FindStartAndEndIndex(userInput);
Print(startAndEndIndex, userInput);
AddSequencesForTotal(startAndEndIndex, userInput);

static List<(int, int)> FindStartAndEndIndex(string userInput)
{
    List<(int, int)> indexes = new List<(int Start, int End)>();

    for (int i = 0; i < userInput.Length; i++)
    {
        for (int j = i + 1; j < userInput.Length; j++)
        {
            if (CorrectSequence(i, j, userInput))
                indexes.Add((i, j));
        }
    }
    return indexes;
}
static bool CorrectSequence(int start, int end, string stringInput)
{
    if (start < end && stringInput[start] == stringInput[end])
    {
        string sequence = stringInput.Substring(start, end - start + 1);
        bool isAllDigits = sequence.All(char.IsDigit);
        bool containsSameNumber = sequence
            .Substring(1, sequence.Length - 2)
            .Contains(stringInput[start]);

        if (isAllDigits && !containsSameNumber)
            return true;
    }
    return false;
}
static void Print(List<(int Start, int End)> startAndEndIndex, string stringInput)
{
    foreach (var (Start, End) in startAndEndIndex)
    {
        for (int j = 0; j < stringInput.Length; j++)
        {
            bool isColor = j >= Start && j <= End;
            Console.ForegroundColor = isColor ? ConsoleColor.Magenta : ConsoleColor.Gray;
            Console.Write(stringInput[j]);
        }
        Console.ResetColor();
        Console.WriteLine();
    }
}
static void AddSequencesForTotal(List<(int Start, int End)> startAndEndIndex, string stringInput)
{
    long total = 0;
    foreach (var (Start, End) in startAndEndIndex)
        total += long.Parse(stringInput.Substring(Start, End - Start + 1));

    Console.WriteLine($"\nTotal: {total}");
}