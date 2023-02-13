string[] array = { "кот", "волк", "сок", "муха", "бук", "куб" };
int size = NumberOfShortElements(array);
string[] newArray = new string[size];
newArray = FillArray(array, newArray);
Print(array);
Print(newArray);


// ---------------Methods---------------------

int NumberOfShortElements(string[] arr)
{
    int count = 0;
    foreach (string el in arr)
    {
        if (el.Length < 4) count++;
    }
    return count;
}

string[] FillArray(string[] massiv, string[] collection)
{
    // string[] collection = new string[num];
    for (int i = 0; i < massiv.Length;)
    {
        for (int j = 0; j < collection.Length;)
        {
            if (massiv[i].Length < 4)
            {
                collection[j] = massiv[i];
                i++; j++;
            }
            else i++;
        }
    }
    return newArray;
}

void Print(string[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write($"{col[i] + " "}");
    }
    Console.WriteLine();
}

