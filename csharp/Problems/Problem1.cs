namespace ProjectEuler;

public class Problem1 : IProblem
{
    public string GetSolution()
    {
        const int SumTo = 1000;

        var sum = Enumerable.Range(0, SumTo).Where(x => (x % 3 == 0) || (x % 5 == 0)).Sum();
        return sum.ToString();
    }
}