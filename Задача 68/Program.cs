// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int GetNumberFromConsole(string numberName)
{
    Console.Write(numberName + " = ");
    return Convert.ToInt32(Console.ReadLine());
}

int AckermannFunction(int firstArg, int secondArg)
{
    if (firstArg == 0)
    {
        return secondArg + 1;
    }
    else if (firstArg > 0 && secondArg == 0)
    {
        return AckermannFunction(firstArg - 1, 1);
    }
    else if (firstArg > 0 && secondArg > 0)
    {
        return AckermannFunction(firstArg - 1, AckermannFunction(firstArg, secondArg - 1));
    }
    return 0;
}

int numberM = GetNumberFromConsole("m");
int numberN = GetNumberFromConsole("n");
Console.Write("A(m,n) = ");
Console.Write(AckermannFunction(numberM, numberN));