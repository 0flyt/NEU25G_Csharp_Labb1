using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

static string[,] FindSequence(string numbers)
{
    string foundSequences = "";
    string foundSequencesIndex = "";

    for (int i = 0; i < numbers.Length; i++)
    {
        if (!char.IsDigit(numbers[i]))
            continue;

        for (int j = 1; j < numbers.Length; j++)
        {
            if (!char.IsDigit(numbers[j]))
                continue;

            if (numbers[i] == numbers[j] && i < j)
            {
                string foundSequence = "";
                string foundSequenceIndex = "";
                for (int n = i; n <= j; n++)
                {
                    foundSequence += numbers[n];
                    foundSequenceIndex = i.ToString();
                    if (!char.IsDigit(numbers[n]))
                    {
                        foundSequence = "";
                        foundSequenceIndex = "";
                        break;
                    }

                }
                if (foundSequence.Length > 0)
                {
                    if (foundSequences == "")
                        foundSequences = foundSequence;
                    else
                        foundSequences += " " + foundSequence;

                }

                if (foundSequenceIndex.Length > 0)
                {
                    if (foundSequencesIndex == "")
                        foundSequencesIndex = foundSequenceIndex;
                    else
                        foundSequencesIndex += " " + foundSequenceIndex;

                }

                break;
            }
        }
    }

    string[] foundSequencesArray = foundSequences.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    string[] foundIndexArray = foundSequencesIndex.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    string[,] sequencesAndIndex = new string[foundSequencesArray.Length, 2];

    for (int i = 0; i < foundSequencesArray.Length; i++)
    {
        sequencesAndIndex[i, 0] = foundSequencesArray[i];
        sequencesAndIndex[i, 1] = foundIndexArray[i];
    }

    return sequencesAndIndex;
}

static void MarkedSequence(string exampleNumbers, string[,] sequencesAndIndex)
{
    for (int s = 0; s < sequencesAndIndex.GetLength(0); s++)
    {
        int startIndex = int.Parse(sequencesAndIndex[s,1]);
        int endIndex = startIndex + sequencesAndIndex[s, 0].Length;
        string firstExampleNumbers = "";
        string lastExampleNumbers = "";

        for (int i = 0; i < startIndex; i++)
            firstExampleNumbers += exampleNumbers[i];

        for (int j = endIndex; j < exampleNumbers.Length; j++)
            lastExampleNumbers += exampleNumbers[j];

        Console.Write(firstExampleNumbers);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write(sequencesAndIndex[s,0]);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(lastExampleNumbers);
    }

}

static BigInteger AddingNumbers(string[,] foundSequences)
{
    BigInteger total = 0;

    for (int i = 0; i < foundSequences.GetLength(0); i++)
    {
        total += BigInteger.Parse(foundSequences[i,0]);
    }

    return total;
}

Console.ForegroundColor = ConsoleColor.White;

Console.Write("Skriv in text med olika tal: ");
string exampleNumbers = Console.ReadLine();

Console.WriteLine();

string[,] foundSequences = FindSequence(exampleNumbers);
MarkedSequence(exampleNumbers, foundSequences);

Console.WriteLine();
Console.WriteLine($"Total: {AddingNumbers(foundSequences)}");