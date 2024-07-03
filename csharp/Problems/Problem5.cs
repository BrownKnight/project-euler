namespace ProjectEuler;

public class Problem5 : IProblem
{
    public string GetSolution()
    {
        var number = 10;
        while (true)
        {
            if (IsEvenlyDivisible(number)) break;
            number++;
        }

        return number.ToString();
    }

    private bool IsEvenlyDivisible(int number)
    {
        for (var i = 2; i <= 20; i++)
        {
            if (number % i != 0) return false;
        }
        return true;
    }
}