//  Задача 1: 
//  Пользователь вводит с клавиатуры M чисел. 
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int PromptInt(string message)
{
    System.Console.Write($"{message} > ");
    string inputedStr = Console.ReadLine();
    int value;
    if (int.TryParse(inputedStr, out value))
    {
        return value;
    }
    System.Console.WriteLine($"Извините, но '{inputedStr}' не является целым числом");
    Environment.Exit(0);
    return 0;
}
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
double[] GenerateArray(int len)
{
    double[] array = new double[len];
    return array;
}
void PrintArray(double[] array)
{
    foreach (var item in array)
    {
        System.Console.Write($"{item} ");
    }
}
void AddNumberToArray(int len, double[] array)  //С циклом было бы проще, но рекурсию использовал умышленно
{
    if (len > 0)
    {
        double num = PromptDouble($"Введите {array.Length + 1 - len}-е число");
        array[array.Length - len] = num;
        AddNumberToArray(len-1, array);
    }
    else
    {
        PrintArray(array);
    }
}
void CountPositiveNumbers(double[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item > 0)
        {
            count++;
        }
    }
    System.Console.WriteLine($"Количество чисел больше ноля = {count}");  
}

int lenArr = PromptInt("Введите количество вводимых чисел");
double[] Numbers = GenerateArray(lenArr);
AddNumberToArray(lenArr, Numbers);
CountPositiveNumbers(Numbers);