int GetLength(string[] array, int maxCharCount)
{
    int length = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxCharCount) length++;
    }
    return length;
}

string[] CreateNewArray(string[] array, int maxCharCount)
{
    int length = GetLength(array, maxCharCount);
    string[] newArray = new string[length];
    int position = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxCharCount)
        {
            newArray[position] = array[i];
            position++;
        }
    }
    return newArray;
}
Console.Write("Введите ограничение по количеству символов: ");
int maxCharCount = int.Parse(Console.ReadLine()!);
Console.Write("Введите строки через пробел: ");
string[] st = Console.ReadLine()!.Split();
Console.Write(String.Join(" ", CreateNewArray(st, maxCharCount)));