// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9;

Console.Write("Введите число M : ");
int numM = int.Parse(Console.ReadLine());

Console.Write("Введите число N : ");
int numN = int.Parse(Console.ReadLine());


int Akkerman (int numM, int numN)
{
    if (numM == 0) return numN + 1;
    if (numN == 0) return Akkerman(numM - 1, 1);
    else return Akkerman(numM - 1, Akkerman(numM, numN - 1));
return Akkerman(numM, numN);
}

Console.WriteLine($"Функция Аккермана для чисел ({numM},{numN}) = {Akkerman(numM, numN)}");