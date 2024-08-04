// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29 ?

void Main() 
{ 
    System.Console.Write("Введите число m: "); 
    int m = int.Parse(Console.ReadLine()); 
 
    System.Console.Write("Введите число n: "); 
    int n = int.Parse(Console.ReadLine()); 
 
    int result = AckFun(m, n); 
    Console.WriteLine($"A({m},{n}) = {result}"); 
} 
 
 int AckFun(int m, int n) 
{ 
     if (m == 0) 
        return n + 1; 
    else if (n == 0) 
        return AckFun(m - 1, 1); 
    else 
        return AckFun(m - 1, AckFun(m, n - 1)); 
} 
Main();
