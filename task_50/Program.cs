// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {        
            for (int j = 0; j < matrix.GetLength(1); j++)
                matrix [i, j] = new Random().Next(0, 11);
        }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + " \t");
        Console.WriteLine(); 
    }
}
Console.Write("Введите номер строки: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [4, 3];
InputMatrix(matrix);
PrintMatrix(matrix);
if (n > matrix.GetLength(0) || m > matrix.GetLength(1))
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine("Значение элемента: " + matrix[n-1,m-1]);
}