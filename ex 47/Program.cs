Console.Clear();
Console.Write("Enter matrix size:");
int m =Convert.ToInt32(Console.ReadLine());
int n =Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[m, n];


void PrintArray(double[,] matr)
{
for (int i =0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        Console.Write($" {matr[i, j]} ");
    }
    Console.WriteLine();
}
}

void FillArray(double[,] matr)
{
    for (int i =0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
matr[i, j] =  Math.Round(new Random().NextDouble()*100, 2);
    }
}
}

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine(matrix[0, 0]);
