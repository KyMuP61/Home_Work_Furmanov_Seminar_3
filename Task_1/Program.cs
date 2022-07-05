/*
Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да

*/



Console.Clear();
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();

 if (number.ToCharArray()[0] == number.ToCharArray()[4] 
|| number.ToCharArray()[1] == number.ToCharArray()[3])
{
    Console.WriteLine("Данное число является палиндромом ");
}
else
{
    Console.WriteLine("Число не является палиндромом ");
}
