namespace ProjectEuler;

public class Problem2 : IProblem
{
    public string GetSolution()
    {
        const int MaxNumbers = 4_000_000;

        var sequence = new List<int>() { 1, 2 };
        while (true)
        {
            sequence.Add(sequence[^1] + sequence[^2]);
            if (sequence.Last() > MaxNumbers) break;
        }

        return sequence.Where(x => x % 2 == 0).Sum().ToString();
    }
}