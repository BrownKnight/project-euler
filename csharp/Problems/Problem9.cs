namespace ProjectEuler;

public class Problem9 : IProblem
{
    public string GetSolution()
    {
        for (var a = 1; a < 1000; a++)
        {
            for (var b = 1; b < 1000; b++)
            {
                for (var c = 1; c < 1000; c++)
                {
                    if (a + b + c != 1000) continue;
                    if ((a*a) + (b*b) == (c*c)) return (a * b * c).ToString();
                }
            }
        }

        return "No solution found";
    }
}