string exampleNumbers = "29535123p48723487597645723645";

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
                    {
                        foundSequences = foundSequence;
                    }
                    else
                    {
                        foundSequences += " " + foundSequence;
                    }
                        
                }
                
                break;
            }
        }
    }
    
    return foundSequences;
}

static void MarkedSequences(string foundSequences)
{
    string exampleNumbers = "29535123p48723487597645723645";
    string[] sequenceArray = foundSequences.Split(' ');

    foreach (var sequence in sequenceArray)
    {
        int startIndex = exampleNumbers.IndexOf(sequence);

        if (startIndex >= 0)
        {
            int endIndex = startIndex + sequence.Length - 1;

            Console.WriteLine(startIndex + " " + endIndex);
        }
        
        //for (int j = 0; j < exampleNumbers.Length; j++)
        //{

        //}
        //string markedSequence = sequence;
        ////Console.ForegroundColor = ConsoleColor.Magenta;
        ////Console.Write($"{sequence}");
        ////Console.ForegroundColor = ConsoleColor.White;
        ////Console.Write("test");
        //for (int i = sequence.Length; i < exampleNumbers.Length; i++)
        //{
        //    markedSequence += exampleNumbers[i];
        //}
        //Console.WriteLine(markedSequence);
    }
}

//FindSequence(exampleNumbers);
MarkedSequences(FindSequence(exampleNumbers));
