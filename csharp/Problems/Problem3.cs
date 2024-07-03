namespace ProjectEuler;

public class Problem3 : IProblem
{
    public string GetSolution()
    {
        const long Input = 600851475143;

        var factors = Factorize(Input);
        return string.Join(',', factors);
    }

    private long[] Factorize(long input)
    {
        for (var i = 2; i < input; i++)
        {
            var div = input / i;
            if (div * i == input)
            {
                return [..Factorize(div), ..Factorize(i)];
            }
        }

        return [input];
    }
}