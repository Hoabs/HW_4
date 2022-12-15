Console.WriteLine("Enter length of array");
int len = Convert.ToInt32(Console.ReadLine());

int[] array = new int[len];

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Enter {i + 1} element of array");
    int elem = Convert.ToInt32(Console.ReadLine());
    array[i] = elem;
}

Console.WriteLine($"[{string.Join(", ", array)}]");