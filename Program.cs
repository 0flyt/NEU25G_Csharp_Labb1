Console.Write("Skriv en text: "); // 29535123p48723487597645723645
string userInput = Console.ReadLine();
FindStartAndEndIndex(userInput);

static void FindStartAndEndIndex(string stringInput)
{
    string startIndexs = "";
    string endIndexs = "";
    for (int i = 0; i < stringInput.Length; i++)
    {
        for (int j = i + 1; j < stringInput.Length; j++)
        {
            if (CorrectSequence(i, j, stringInput))
            {
                startIndexs += i + " ";
                endIndexs += j + " ";
            }
        }
    }
    Print(startIndexs, endIndexs, stringInput);
}

static bool CorrectSequence(int start, int end, string stringInput)
{
    if (start < end && stringInput[start] == stringInput[end])
    {
        string sequence = stringInput.Substring(start, end - start + 1);
        if (!sequence.Any(char.IsLetter) && !sequence.Substring(1, sequence.Length - 2).Contains(stringInput[start]))
            return true;
    }
    return false;
}

static void Print(string start, string end, string stringInput)
{
    int[] startIndex = start.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    int[] endIndex = end.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

    for (int i = 0; i < startIndex.Length; i++)
    {
        for (int j = 0; j < stringInput.Length; j++)
        {
            bool isColor = false;
            if (j >= startIndex[i] && j <= endIndex[i])
                isColor = true;

            Console.ForegroundColor = isColor ? ConsoleColor.Magenta : ConsoleColor.Gray;
            Console.Write(stringInput[j]);
        }
        Console.ResetColor();
        Console.WriteLine();
        
    }
    AddSequencesForTotal(startIndex, endIndex, stringInput);
}

static void AddSequencesForTotal(int[] startIndex, int[] endIndex, string stringInput)
{
    long total = 0;
    for (int i = 0; i < startIndex.Length; i++)
        total += long.Parse(stringInput.Substring(startIndex[i], endIndex[i] - startIndex[i] + 1));

    Console.WriteLine($"\nTotal: {total}");
}