namespace ProjectEuler;

public class Problem4 : IProblem
{
    public string GetSolution()
    {
        var highestPalindrome = 11;
        for (var i = 100; i < 1000; i++)
        {
            for (var j = 100; j < 1000; j++)
            {
                var product = i * j;
                if (IsPalindrome(product) && product > highestPalindrome)
                {
                    highestPalindrome = product;
                }

            }
        }

        return highestPalindrome.ToString();
    }

    private bool IsPalindrome(int input)
    {
        return input.ToString() == new string(input.ToString().Reverse().ToArray());
    }
}