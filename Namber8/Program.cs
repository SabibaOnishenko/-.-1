Console.WriteLine("ВВЕДИТЕ ЧИСЛО");
int numberX = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count<=numberX)
{
    if (count%2==0)
        {
            Console.Write(count);
            Console.Write(", ");
        }
        count++;
}

