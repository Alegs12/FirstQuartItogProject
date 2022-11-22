string[] GetArrayLengthThree(string[] array) // метод
{

    int sizeResult = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            sizeResult++;
        }
    }

    string[] resultAr = new string[sizeResult];
    int indexResult = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            resultAr[indexResult] = array[i];
            indexResult++;
        }
    }
    return resultAr;
}

// решение
System.Console.WriteLine("Введите значения через пробел ");
string[] startArray = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
string[] resultArray = GetArrayLengthThree(startArray);
Console.WriteLine($"[{string.Join(", ", startArray)}] -> [{string.Join(", ", resultArray)}]");