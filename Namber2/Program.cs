﻿
Console.WriteLine("ВВЕДИТЕ ПЕРВОЕ ЧИСЛО");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВЕДИТЕ ВТОРОЕ ЧИСЛО");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1>number2) 
{
    Console.WriteLine(number1);
}
else Console.WriteLine(number2);