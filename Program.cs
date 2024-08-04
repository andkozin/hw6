
// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5" 
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

// void Main()
// {
//     int M = ReadInt("Введите число M: ");
//     int N = ReadInt("Введите число N: ");
    
//     System.Console.Write("\"");
//     PrintNumber( M, N);
//     System.Console.Write(N); // хитрю
//     System.Console.Write("\"");
// }

// void PrintNumber(int number, int N)
// {
   
//     if (number+1  > N) return;
//         //const string quote = "\"";
//     {
//         //Console.Write(number.ToString() + ", ");
//         //System.Console.Write("\""+string.Join(",",number)+"\"");
//         System.Console.Write(number + ", ");  //хитрю
//         //System.Console.Write(" " + string.Join(",",number)+" ");
//         //System.Console.Write(String.Join(",",number));
//         //System.Console.Write("+(number.ToString()) + ", "+");
//         //Console.Write($"{quote} {number+","}, ");
//         //Console.Write(string.Join(number + ","));
//         PrintNumber(number + 1, N);
//     }
// }

// int ReadInt(string msg)
// {
//     System.Console.Write(msg);
//     return Convert.ToInt32(Console.ReadLine());
// }
// Main();

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29 ?

// void Main() 
// { 
//     System.Console.Write("Введите число m: "); 
//     int m = int.Parse(Console.ReadLine()); 
 
//     System.Console.Write("Введите число n: "); 
//     int n = int.Parse(Console.ReadLine()); 
 
//     int result = AckFun(m, n); 
//     Console.WriteLine($"A({m},{n}) = {result}"); 
// } 
 
//  int AckFun(int m, int n) 
// { 
//      if (m == 0) 
//         return n + 1; 
//     else if (n == 0) 
//         return AckFun(m - 1, 1); 
//     else 
//         return AckFun(m - 1, AckFun(m, n - 1)); 
// } 
// Main();

// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1

void Main() 
{ 
    int arraySize = ReadInt("Введите размер массива: "); // обьявляю перем. value корорая равна методу/ ReadIntnt value = ReadInt(); <-13   
    int[] array = GenerateArray(arraySize, 0, 20);
   
    PrintArray(array);
    PrintArrayRev(array, array.Length - 1); 
} 
 
void PrintArrayRev(int[] arr, int index) 
{ 
    if (index >= 0) 
    { 
        Console.Write(arr[index] + " "); 
        PrintArrayRev(arr, index - 1); 
    } 
}
void PrintArray(int[] arrayForPrint)
{
    System.Console.Write("[" + string.Join(", ", arrayForPrint) + "] => "); //метод Join склеить- разделяет запятой и не ставит послед.зпт
}
int[] GenerateArray(int size, int minValue, int maxValue)//метод генерации массива
{
    int[] tempArray = new int[size]; //выделяем память
    Random rand = new Random(); // выделение 
    for (int i = 0; i < tempArray.Length; i++)
        tempArray[i] = rand.Next(minValue, maxValue); //диапозовы чисел а их указал в Main
    return tempArray;
}
int ReadInt(string msg) //
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine()); //сократи
}
Main(); 
