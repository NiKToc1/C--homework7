void InputMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-30, 31);
    }
}


void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]}\t");
        
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine("Введите строку элемента: ");
int stroka = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите столбец элемента: ");
int stolbec = int.Parse(Console.ReadLine()!);

if(stroka > matrix.GetLength(0)|| stolbec > matrix.GetLength(1))
    Console.WriteLine("Такой позиции нет");
else Console.WriteLine($"{matrix[stroka - 1, stolbec - 1]}");
