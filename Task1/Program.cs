// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5" 
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void Main()
{
    int M = ReadInt("Введите число M: ");
    int N = ReadInt("Введите число N: ");
    
    System.Console.Write("\"");
    PrintNumber( M, N);
    System.Console.Write(N); // хитрю
    System.Console.Write("\"");
}

void PrintNumber(int number, int N)
{
   
    if (number+1  > N) return;
        //const string quote = "\"";
    {
        //Console.Write(number.ToString() + ", ");
        //System.Console.Write("\""+string.Join(",",number)+"\"");
        System.Console.Write(number + ", ");  //хитрю
        //System.Console.Write(" " + string.Join(",",number)+" ");
        //System.Console.Write(String.Join(",",number));
        //System.Console.Write("+(number.ToString()) + ", "+");
        //Console.Write($"{quote} {number+","}, ");
        //Console.Write(string.Join(number + ","));
        PrintNumber(number + 1, N);
    }
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
Main();
