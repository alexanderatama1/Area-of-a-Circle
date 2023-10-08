// Declare the variables
double radius, area;

// Prompt for Radius
Console.Write("Enter a radius ");
radius = double.Parse (Console.ReadLine());

// Prompt for area(of a circle)
area = Math.PI * Math.Pow(radius, 2);

// Output to the console
Console.WriteLine("A circle with radius " + radius + " has an area of " + area + ".");