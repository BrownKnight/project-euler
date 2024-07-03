namespace ProjectEuler;

public class Problem7 : IProblem
{
    public string GetSolution()
    {
        const int TargetPrimeCount = 10001;
        var primes = 0;
        var i = 2L;

        while (primes < TargetPrimeCount)
        {
            i++;
            if (IsPrime(i))
            {
                primes++;
            }
        }

        return i.ToString();
    }

    private bool IsPrime(long input)
    {
        for (var i = 2; i < input / 2; i++)
        {
            if (input % i == 0) return false;
        }
        return true;
    }
}