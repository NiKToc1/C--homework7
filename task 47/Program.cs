void InputMatrix(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = Convert.ToDouble(new Random().Next(-300 , 310)) / 10;
    }
}

void PrintMatrix(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]}\t");
        
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размеры массива ");
Console.WriteLine("Количество строк:");
int stroka = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Количество столбцов: ");
int stolbec = Convert.ToInt32(Console.ReadLine()!);
double[,] matrix = new double[stroka, stolbec];
InputMatrix(matrix);
PrintMatrix(matrix);