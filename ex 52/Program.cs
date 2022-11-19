Console.Clear();
Console.WriteLine("Enter matrix size:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArrayRandom(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 101);
        }
    }
}

FillArrayRandom(matrix);
PrintArray(matrix);

double average = 0;

for (int j = 0; j < n; j++)
{
for (int i = 0; i < m; i++)
{


    average = average + matrix[i, j];




}
average = average/m;
Console.Write($"{Math.Round(average, 2)} ");
}

