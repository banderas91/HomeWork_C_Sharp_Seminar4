

// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать функцию Math.Pow()
// 3, 5 -> 243
// 2, 4 -> 16

Console.WriteLine("Введите число А");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int pow = a;


for (int i = 1; i < b; i++)
{
    pow = pow * a;
}
if (a == 0 )
{
    Console.WriteLine ("0 в любой степени будет 0!!!");
    
}
else if (b == 1 )
{
    Console.WriteLine ("Любое число в первой степени равно самому себе");
}

else
{
Console.WriteLine (a + " в степени " + b + " равно "+ pow );
}
