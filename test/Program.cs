string[] str = { "2363", "Word", "646", "hmgm", "1" };
Console.WriteLine(String.Join(" ", str));
int k = 0;
GetLengthArray(str);
string[] result = new string[k];
k = 0;
GetNewArray(str);
PrintArray(result);

int GetLengthArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            k++;
        }
    }
    return k;
}

string[] GetNewArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[k] = array[i];
            k++;
        }
    }
    return result;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}