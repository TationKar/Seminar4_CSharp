//24 Напишите программу, которая принимает на вход число A
// и выдаёт сумму чисел от 1 до A
// a = 5
// sum = 1 + 2 + 3 + 4 + 5

int GetSum(int n){
    int sum = 1;
    for (int i = 1; i <= n; i++)
        sum = sum + 1;
    return sum;
}
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма от 1 до {number} равна {GetSum(number)}");


