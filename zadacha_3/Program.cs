// //  Назовём число «интересным» если его произведение цифр делится на их сумму. 
// Напишите программу, которая заполняет массив на N «интересных» случайных целых чисел. (
//     Каждый эл-т массива должен быть сгенерирован случайно)

 
Console.Write("Укажите размер массива N: "); 
int n = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine(); 
int[] array = new int[n]; 
int i = 0; 
 
Console.Write($"Массив N интересных числ: "); 
 
while (i < n) /
{ 
    double sum = 0; 
    double mult = 1; 
 
    array[i] = new Random().Next(1, 99999);   
    int temp = array[i]; 
     
    while(temp > 0) 
    { 
        int digit = temp%10; 
        temp /= 10; 
 
        sum += digit; 
        mult *= digit;           
    } 
     
    if(mult != 0) 
    { 
        double ost = mult/sum;  
        ost = ost%1;  
        if(ost == 0 ) 
        { 
            Console.Write($" {array[i]}"); 
            i++; 
        } 
    } 
}
