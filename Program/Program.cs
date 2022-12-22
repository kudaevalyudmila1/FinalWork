void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}
string[] SortingArray(string[] arr1, int n)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= n) count++;
        
    }
    int j = 0;
    string[] arr2 = new string[count];
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= n)
        {
            arr2[j] = arr1[i];
            j++;
        }
    }
    return arr2;
}
Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
string[] arrString1 = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i+1} элемент массива:");
    arrString1[i] = Console.ReadLine();
}
PrintArray(arrString1);
Console.Write("->");
string[] arrString2 = SortingArray(arrString1, 3);
PrintArray(arrString2);