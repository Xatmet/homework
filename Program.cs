﻿//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine(" Введите трехзначное число :");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine((num / 10) % 10);

//Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine(" Введите число :");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 100 && num < 1000)
{
    Console.WriteLine(num % 10);
}
else if (num >= 1000 && num < 10000)
{
    Console.WriteLine((num / 10) % 10);
}
else if (num >= 10000 && num < 100000)
{
    Console.WriteLine((num / 100) % 10);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}

//Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine(" Введите цифру дня недели :");
int day = Convert.ToInt32(Console.ReadLine());
if (day <= 5)
{
    Console.WriteLine("Нет,Будний день!");
}
else
{
    Console.WriteLine("Да,Ура, выходной день!");
}

