/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/


Console.Clear();


int InputNumber(string messange)
{
    int result = 0;
    Console.WriteLine(messange);
    while(true)
    {
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Вы не ввели число. Введите число");
        }
    }
return result;
}


void SqrtTable(int number)
{
    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine(Math.Pow(i, 3));
    }
}

SqrtTable(InputNumber("Введите число")); 
