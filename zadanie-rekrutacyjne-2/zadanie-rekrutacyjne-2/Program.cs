static double CalculateCircleSurfaceArea(double radius)
{
    return Math.PI * Math.Pow(radius, 2);
}

static double CalculateCircleCircumference(double radius)
{
    return 2 * Math.PI * radius;
}

Console.Write("radius: ");
double radius = double.Parse(Console.ReadLine());
Console.WriteLine($"circle surface area = {CalculateCircleSurfaceArea(radius)}");
Console.WriteLine($"circle circumference = {CalculateCircleCircumference(radius)}");
