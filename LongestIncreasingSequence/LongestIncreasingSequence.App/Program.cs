using LongestIncreasingSequence.Lib;

Console.WriteLine("Hello, Please enter the integer number sequence seprated by space. Please press ENTER to see the Longest Increasing Sequence.");

// Get the sequence from user input
var sequence = Console.ReadLine()!.Trim().Split(" ", StringSplitOptions.TrimEntries);
List<int> lstSequence = new List<int>();

try
{
    // Convert string sequence to int.
    lstSequence = Array.ConvertAll(sequence, int.Parse).ToList();

    // Call function to find the solution
    var solution = new LongestIncreasingSequenceProblem(lstSequence).FindLongestIncreasingSequence();

    // Write the solution in console.
    Console.WriteLine(Environment.NewLine + "Here is the Longest Increasing Sequence !!");
    Console.WriteLine(string.Join(" ", solution));

}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());    
}


Console.WriteLine(Environment.NewLine + "Press any key to exit.");
Console.ReadLine();


