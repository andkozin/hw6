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

