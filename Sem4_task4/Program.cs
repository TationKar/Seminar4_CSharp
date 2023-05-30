//30 Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]
// int a = new Random().Next(2, 7);
// int b = new Random().Next(2);
// Console.WriteLine($"a = {a},b = {b}");

int[] ArrayRand(int sz){
int[] digit = new int[sz];
for (int i = 0; i < sz; i++)
    digit[i] = new Random().Next(2); 
return digit;
}

void printArr(int []arr){
    // for (int i = 0; i < 8; i++)
    //     Console.Write($"{arr[i]} ");
    Console.WriteLine($"[{String.Join(", ", arr)}]");    
}

Console.Clear();
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] arrNum = ArrayRand(size);
Console.WriteLine();
printArr(arrNum);
//Console.WriteLine();

//Console.WriteLine($"[{String.Join("; ---", array)}]");