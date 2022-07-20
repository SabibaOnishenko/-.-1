Console.WriteLine("ВВЕДИТЕ ПЕРВОЕ ЧИСЛО");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВЕДИТЕ ВТОРОЕ ЧИСЛО");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВЕДИТЕ ТРЕТЬЕ ЧИСЛО");
int number3 = Convert.ToInt32(Console.ReadLine()); 

int num = number1;
if (number2>num)

{
    num = number2;
}

if (number3>num)

{
    num = number3;
}
Console.Write("Максимальное число:");
Console.Write(num);