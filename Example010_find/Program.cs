//требуется найти элемент массива, раный find
int [] array = {1,2,4,8,5,6,4,8};

int n = array.Length;
int find = 4;

int index = 0;
while (index < n)
{
    if(array [index] == find)
    {
        Console.WriteLine(index);
        //прерви - break
        break;
    }
    // index = index + 1;
    index++;
}
