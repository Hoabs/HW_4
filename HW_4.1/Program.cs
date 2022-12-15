Console.WriteLine("Enter a number");
double num = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter a degree of number");
int d = Convert.ToInt32(Console.ReadLine());

double res = num;

for (int i = 0; i < d - 1; i++)
{
    res = res * num;
}

Console.WriteLine(res);