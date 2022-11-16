try
{
    Console.Write("Задайте количество элементов в массиве (введите натуральное число): ");
    int length = Convert.ToInt32(Console.ReadLine());
    string[] array1 = new string[length];
    string[] array2 = new string[array1.Length];
    if (length == 0)
        Console.WriteLine("Ошибка! Введите натуральное число.");
    else
    {
        void FillArray(string[] array1)
        {
            for (int i = 0; i < length; i++)
            {
                array1[i] = Console.ReadLine();
            }
        }
        void FillArray2(string[] array1, string[] array2)
        {
            int count = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i].Length <= 3)
                {
                    array2[count] = array1[i];
                    count++;
                }
            }
        }
        void PrintArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                    Console.Write($"{array[i]}]");
                else
                    {Console.Write($"{array[i]}");
                Console.Write(" ");}
            }
        }
        Console.WriteLine("Введите массив элементов через Enter");
        FillArray(array1);
        Console.Write("Задан массив из следующих элементов [");
        PrintArray(array1);
        FillArray2(array1, array2);
        Console.WriteLine();
        Console.Write("Из заданного массива выведены только элементы длина которых меньше, либо равна 3 символам [");
        PrintArray(array2);
    }
}
catch
{
    Console.WriteLine("Ошибка! Введите натуральное число.");
}
