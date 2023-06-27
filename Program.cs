
Console.WriteLine("Инициализируем матрицу 3х3 со значениями:");
int[,] numbers = new int[3, 3];

Random ran = new();

for (int row = 0; row < numbers.GetLength(0); row++)
{
    for (int col = 0; col < numbers.GetLength(1); col++)
    {
        numbers[row, col] = ran.Next(-100, 100);

        Console.WriteLine("{0}\t", numbers[row, col]);
    }
    Console.WriteLine();
}

Console.WriteLine("Выводим максимальный элемент в каждом ряду:");

for (int row = 0; row < numbers.GetLength(0); row++)
{
    int maxElement = numbers[row, 0];

    for (int col = 0; col < numbers.GetLength(1); col++)
    {
        if (numbers[row, col] > maxElement)
        {
            maxElement = numbers[row, col];
        }
    }

    Console.WriteLine($"Ряд {row + 1}: {maxElement}");
}
