System.Console.WriteLine("Введите значения через пробел ");
string[] startArray = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int sizeResult = 0;
int indexResult = 0;

for (int i = 0; i < startArray.Length; i++)
{
    if (startArray[i].Length <= 3)
    {
        sizeResult++;
    }
}
string[] resultArray = new string[sizeResult];

for (int i = 0; i < startArray.Length; i++)
{
    if (startArray[i].Length <= 3)
    {
        resultArray[indexResult] = startArray[i];
        indexResult++;
    }
}

Console.WriteLine($"[{string.Join(", ", startArray)}] -> [{string.Join(", ", resultArray)}]");