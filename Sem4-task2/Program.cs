// 26 Напишите программу,
//  которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
Console.Clear();

int Method(int number){
    int count = 0;
    while (number > 0)
    {
        if (number % 10 > 0)
            count++;
            number = number /10;
    }
    return count;
}

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Для числа {num} количество цифр {Method(num)}");