namespace ProjectEuler;

public class Problem6 : IProblem
{
    public string GetSolution()
    {
        const int Count = 100;

        var sumOfSquares = Enumerable.Range(1, Count).Select(x => x * x).Sum();
        var sum = Enumerable.Range(1, Count).Sum();
        var squareOfSum = sum * sum;

        var difference = squareOfSum - sumOfSquares;
        return difference.ToString();
    }
}