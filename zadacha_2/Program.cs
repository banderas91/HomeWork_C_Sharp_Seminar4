// Задача 2:* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе, которые являются делителями этого числа. 
//(для получения цифр числа операцию приведения числа к строке не использовать)
// 452 -> 6
// 82 -> 2
// 9012 -> 3
// 23 -> 0

Console.WriteLine("Введите число А: "); 
int a = Convert.ToInt32(Console.ReadLine()); 
double b = a; 
int result = 0; 
 
while(a > 0) 
{ 
    int digit = a%10; 
    a /= 10; 
    double ost = b / digit; 
    ost = ost%1;  
    if(ost == 0) 
    { 
        result += digit; 
         
    } 
} 
Console.WriteLine(result);