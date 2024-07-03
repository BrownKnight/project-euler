using System.Diagnostics;
using ProjectEuler;

if (args.Length != 1)
{
    Console.WriteLine("Unexpected arguments provided");
    return;
}

var problemNumber = args[0];

var problemTypes = typeof(IProblem).Assembly.GetTypes().Where(t => t.IsAssignableTo(typeof(IProblem)));

var problemType = problemTypes.SingleOrDefault(t => t.Name == $"Problem{problemNumber}");
if (problemType is null)
{
    Console.WriteLine($"Could not found problem {problemNumber}");
    return;
}

var problem = (IProblem)Activator.CreateInstance(problemType)!;

var stopwatch = Stopwatch.StartNew();

Console.WriteLine($"Executing problem {problemNumber}");
var solution = problem.GetSolution();

Console.WriteLine($"Executed problem {problemNumber} in {stopwatch.ElapsedMilliseconds}ms");
Console.WriteLine($"Solution: {solution}");
