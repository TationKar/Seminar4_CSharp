//30 Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.
 //[1,0,1,1,0,1,0,0]
// int a = new Random().Next(2, 7);
// int b = new Random().Next(2);
// Console.WriteLine($"a = {a},b = {b}");

int[] ArrayRand(){
    int[] digit = new int[8];
for (int i = 0; i < 8; i++)
{
    digit[i] = new Random().Next(0, 2); 
}
return digit;
}

void printArr(int []arr){
    for (int i = 0; i < 8; i++)
{
    Console.Write($"{arr[i]} ");    
}
}

Console.Clear();
int[] arrNum = ArrayRand();
Console.WriteLine();
printArr(arrNum);
Console.WriteLine();
