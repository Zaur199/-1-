int[] array = {1, 2, 3, 9, -8, 6, 0, -4};
Console.Write("Текущий массив:");

 for(int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();

Console.Write("Преобразованный массив:");
for(int i = 0; i < array.Length - 5; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();