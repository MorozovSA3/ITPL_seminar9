// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int GetNumberFromConsole(string numberName)
{
    Console.Write(numberName +" = ");
    return Convert.ToInt32(Console.ReadLine());
}

int NaturalNumbersBetweenSum(int startNumber, int lastNumber)
{
    if (lastNumber > startNumber)
    {
        int naturalSum = 0;
        for (int i = startNumber; i <= lastNumber; i++)
        {
            naturalSum += i;
        }
        return naturalSum;
    }
    else if (startNumber == lastNumber)
        return startNumber;
    
    return 0;
}

int numberM = GetNumberFromConsole("M");
int numberN = GetNumberFromConsole("N");
Console.Write(NaturalNumbersBetweenSum(numberM, numberN));