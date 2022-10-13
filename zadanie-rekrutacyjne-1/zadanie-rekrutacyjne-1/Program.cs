static double CalculateDistanceBetweenPoints(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
}

Console.Write("x1: ");
double x1 = double.Parse(Console.ReadLine());

Console.Write("y1: ");
double y1 = double.Parse(Console.ReadLine());

Console.Write("x2: ");
double x2 = double.Parse(Console.ReadLine());

Console.Write("y2: ");
double y2 = double.Parse(Console.ReadLine());

Console.WriteLine($"distance between ({x1}; {y1}) and ({x2}; {y2}) = " +
    $"{CalculateDistanceBetweenPoints(x1, y1, x2, y2)}");
