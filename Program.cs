string[] NewArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count += 1;
        }
    }

    string[] newArray = new string[count];
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[k] = array[i];
            k += 1;
        }
    }
    return newArray;
}

void PrintNewArray(string[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write($"[ {newArray[i]} ]");
    }
}

string[] array = { "Hello", "2", "world", ":-)" };
string[] result = NewArray(array);

PrintNewArray(result);

