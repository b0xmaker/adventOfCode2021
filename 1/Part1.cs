//Part 1:

class ReadFromFile
{
 static void Main()
    {

        int depth = 0;         // current depth number
        int numberCount = 0;    // number of times a depth has increased
        
        string[] lines = System.IO.File.ReadAllLines(@"C:\Users\agerig\Desktop\adventOfCode2021\1\input.txt");

        // output the current depth, increase depth number if depths are increasing
        System.Console.WriteLine("Contents of input.txt = ");
        foreach (string line in lines)
        {
            

            // convert the string to an integer and post value
            int iLine = System.Convert.ToInt16(line);
            Console.WriteLine("Depth value is " + iLine);



            // if the current number is greater than the previous number
            if(iLine > depth)
            {
                // increase the tally count and post current number to console
                numberCount++;
                Console.WriteLine("\t" + "Depth increased! Depth counter is: " + numberCount);
            }

            // remember current number for next loop
            depth = iLine;
            
        }

 
    }
}


//correct answer is 1722
