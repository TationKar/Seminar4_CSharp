//28 Напишите программу, которая принимает на вход число N 
//и выдаёт произведение чисел от 1 до N.

//4-> 24
//5-> 120 == 1 * 2 * 3 * 4 * 5

int Mult(int n){
    int multNum = 1;
    for (int i = 1; i <= n; i++)
    {
        multNum = multNum * i;
    }
    return multNum;
}

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Для числа {num} произведение всех {Mult(num)}");