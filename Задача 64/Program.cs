// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int GetNumberFromConsole()
{
    Console.Write("N = ");
    return Convert.ToInt32(Console.ReadLine());
}

string WriteNumbersRecursion(int startNumber, int lastNumber)
{
    if (startNumber > lastNumber)
        return startNumber + ", " + WriteNumbersRecursion(startNumber - 1, lastNumber);
    else if (startNumber == lastNumber)
        return startNumber + "";
    
    return string.Empty;
}

int number = GetNumberFromConsole();
Console.Write(WriteNumbersRecursion(number, 1));