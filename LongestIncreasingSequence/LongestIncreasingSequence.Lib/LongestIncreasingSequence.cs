namespace LongestIncreasingSequence.Lib
{
    public record LongestIncreasingSequenceProblem(List<int> input)
    {

        public List<int> FindLongestIncreasingSequence()
        {

            if (input.Count == 1) return input;

            List<int> result = new List<int>();
            List<int> tempResult = new List<int>();

            for (int i = 1; i < input.Count; i++)
            {
                if (input[i - 1] < input[i])
                {
                    if (tempResult.Count == 0) tempResult.Add(input[i - 1]);
                    tempResult.Add(input[i]);
                }
                else
                {
                    // Save temp result to result
                    if (result.Count < tempResult.Count)
                        result = tempResult.ToList();

                    tempResult.Clear();
                }
            }

            if (result.Count < tempResult.Count)
                result = tempResult;

            return result;
        }
    }
}