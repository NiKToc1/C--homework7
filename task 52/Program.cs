void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 101);
    }
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]}\t");

        Console.WriteLine();
    }
}

Console.Clear();

Console.Write("Введите количество строк: ");
int stroka = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int stolbec = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[stroka, stolbec];

InputMatrix(matrix);
PrintMatrix(matrix);

for(int j = 0; j < matrix.GetLength(1); j++)
{
    double avg = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
        avg = avg + matrix[i, j];
    avg = (avg / stroka);
    Console.WriteLine($"{Math.Round(avg, 2)}; ");
}

Console.WriteLine();