int[] array = new int[10];



void FillArray(int[] collection/*тут может быть любое название*/) // void   - не возвращает ничего????? нет return, в место collection могло бы arg1
{
    int len = collection.Length;
    int i = 0;
    while (i < len)
    {
        collection[i] = new Random().Next(1, 10);
        i++;
    }
}

void PrintArray(int[] colect)
{
    int count = colect.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(colect[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int i = 0;
    int position = 0;
    while(i < count)
    {
        if(collection[i] == find)
        {
            position = i;
            break;
        }
        i++;

    }
    return position;
}

FillArray(array);
PrintArray(array);
Console.WriteLine("========================================================");

int pos = IndexOf(array,4);
Console.WriteLine(pos);

