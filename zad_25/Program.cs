/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.*/

//1 вариант:  Console.WriteLine(Math.Pow(number,stepen));

int GetNumber(string messege)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(messege);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Повторите ввод!");
        }
    }
    return result;
}

int NatStepen(int number, int stepen)
{
    int result = 1;
    for (int i = 1; i <= stepen; i++)
    {
        result = result * number;
    }
    return result;
}

int number = GetNumber("Введите первое число: ");
int stepen = GetNumber("Введите второе число: ");
Console.WriteLine(NatStepen(number,stepen));