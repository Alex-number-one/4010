double b1 = double.Parse(Console.ReadLine());
double k1 = double.Parse(Console.ReadLine());
double b2 = double.Parse(Console.ReadLine());
double k2 = double.Parse(Console.ReadLine());
double x = (b2 - b1) / (k1 - k2);
double y = ( k1 * (b2 - b1) / (k1 - k2) ) + b1;

Console.WriteLine(x);
Console.WriteLine(y);