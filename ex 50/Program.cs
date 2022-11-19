Console.Clear();
Console.WriteLine("Enter matrix size:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[m, n];


void PrintArray(double[,] matr)
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

void FillArrayPerson(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.WriteLine($"Enter number fot this position: ({i + 1};{j + 1})");
            matr[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

void FillArrayRandom(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Math.Round(new Random().NextDouble() * 100, 2);
        }
    }
}

Console.Write("How do you want to fill array: Press 1 - fill by yourself, Press any other for filling random numbers.  ");
int button = Convert.ToInt32(Console.ReadLine());
if (button == 1)
{
    FillArrayPerson(matrix);

}
else
{
    FillArrayRandom(matrix);

}
PrintArray(matrix);

Console.WriteLine("Enter number position:");
int i = Convert.ToInt32(Console.ReadLine());
int j = Convert.ToInt32(Console.ReadLine());
while (i > m | j > n)
{

    Console.WriteLine($"Choose another position:");
    i = Convert.ToInt32(Console.ReadLine());
    j = Convert.ToInt32(Console.ReadLine());

}
double number = matrix[i - 1, j - 1];
Console.WriteLine($"Your number = {number}");


