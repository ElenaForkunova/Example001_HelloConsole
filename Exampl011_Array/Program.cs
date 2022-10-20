void FillArray(int []collection)
{
    // длина массива
    int Length = collection.Length;
    // индекс по умолчанию начинается с ноля
    int index = 0;
    while (index < Length)
    {
        collection[index] =  new Random().Next (1,10);
        //index = index + 1;
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position =0;
    while (position < count )
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    //если такой элемент не найдет, то выведет -1
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
    {
        position = index;
        //если добавит брейк, то после нахождения первого вхождения, остановка
        //если нужно посденее вхождение, то не ставим брейк
        break;
    }
    index++;
    }
    return position;
}


// создай новый массив с 10 элементами new int [10] по умолчанию наполнен нулями
int [] array = new int [10];

FillArray(array);
PrintArray(array);
Console.WriteLine();
//ищем "4"
int pos = IndexOf (array,4);
Console.WriteLine(pos);