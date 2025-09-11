using System.Numerics;

static string FindSequence(string numbers)
{
    string foundSequences = "";
    
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
                for (int n = i; n <= j; n++)
                {
                    foundSequence += numbers[n];
                    if (!char.IsDigit(numbers[n]))
                    {
                        foundSequence = "";
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
                
                break;
            }
        }
    }
    
    return foundSequences;
}

static string RemoveDuplicates(string foundSequences)
{
    string[] inputSequences = foundSequences.Split(' ');
    string[] outputSequences = new string[inputSequences.Length];
    string removedDuplicates = "";

    foreach (var sequence in inputSequences)
    {
        if (!outputSequences.Contains(sequence))
        {
            outputSequences = outputSequences.Append(sequence).ToArray();
        }
        
    }

    foreach (var item in outputSequences)
    {
        if (item != null)
        {
            if (removedDuplicates == "")
            {
                removedDuplicates = item;
            }
            else
            {
                removedDuplicates += " " + item;
            }
                
        }
    }

    return removedDuplicates;

}

static int FindStartIndex(string sequence, string exampleNumbers)
{
        for (int i = 0; i < exampleNumbers.Length - sequence.Length + 1; i++)
        {

            bool found = true;

            for (int j = 0; j < sequence.Length; j++)
            {
                
                if (exampleNumbers[i + j] != sequence[j])
                {
                    found = false;
                    break;
                }
             
            }
            if (found)
                return i;


        }
    return -1;
    }

static void MarkedSequence(string exampleNumbers, string[] foundSequences)
{
    foreach (var sequence in foundSequences)
    {
        int startIndex = FindStartIndex(sequence, exampleNumbers);
        int endIndex = startIndex + sequence.Length;
        string firstExampleNumbers = "";
        string lastExampleNumbers = "";

        for (int i = 0; i < startIndex; i++)
            firstExampleNumbers += exampleNumbers[i];

        for (int j = endIndex; j < exampleNumbers.Length; j++)
            lastExampleNumbers += exampleNumbers[j];
        
        Console.Write(firstExampleNumbers);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write(sequence);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(lastExampleNumbers);
    }
    
}

static BigInteger AddingNumbers(string[] foundSequences)
{
    BigInteger total = 0;

    foreach (var sequence in foundSequences)
        total += BigInteger.Parse(sequence);

    return total;
}

Console.ForegroundColor = ConsoleColor.White;

Console.Write("Skriv in text med olika tal: ");
string exampleNumbers = Console.ReadLine();

Console.WriteLine();

string[] foundSequences = RemoveDuplicates(FindSequence(exampleNumbers)).Split(' ');
MarkedSequence(exampleNumbers, foundSequences);

Console.WriteLine();
Console.WriteLine($"Total: {AddingNumbers(foundSequences)}");