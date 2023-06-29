//  Задача 2. 
//  Напишите программу, которая найдёт точку пересечения двух прямых, 
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double PromptDouble(string message)
{
    System.Console.Write($"{message} > ");
    string inputedStr = Console.ReadLine();
    double value;
    if (double.TryParse(inputedStr, out value))
    {
        return value;
    }
    System.Console.WriteLine($"Извините, но '{inputedStr}' не является числом");
    Environment.Exit(0);
    return 0;
}
(double, double) PointOfIntersection(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = (k2 * b1 - k1 * b2) / (k2 - k1); //Либо double y = k1*(b2-b1)/(k1-k2)+b1;  double y = k2*(b2-b1)/(k1-k2)+b2;
    return (x, y);
}

double k1 = PromptDouble("Введите угловой коэфициент первой прямой k1");
double b1 = PromptDouble("Введите свободный коэфициент первой прямой b1");
double k2 = PromptDouble("Введите угловой коэфициент второй прямой k2");
double b2 = PromptDouble("Введите свободный коэфициент второй прямой b2");

if (k1 != k2)
{
    (double x, double y) = PointOfIntersection(k1, b1, k2, b2);
    System.Console.WriteLine($"Прямые пересекутся в точке [{Math.Round(x,2)};{Math.Round(y,2)}]");
}
else
{
    System.Console.WriteLine($"Прямые параллельны");
}