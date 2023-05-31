int[] array = new int[8];
PrintArray(array);
Console.WriteLine();
FillArray(array);
PrintArray(array);

int[] PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    return array;
}

int [] FillArray(int[] array)
{
    Random rnd = new Random();

    for(int i = 0; i<array.Length; i++)
    {
        array[i] = rnd.Next(100);
    }
    return array;
}