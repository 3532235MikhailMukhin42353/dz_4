/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.*/

Console.Write("Введите количество элементов в массиве: ");
int elements = Convert.ToInt32(Console.ReadLine());
int [] myArray = new int [elements];
Zapolnenie(myArray);

void Zapolnenie (int [] myArray)
{
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = new Random().Next(-100,101);
        Console.Write(myArray[i]+ "\t");
    }
}