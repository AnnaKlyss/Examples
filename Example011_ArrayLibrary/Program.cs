void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        // index = index +1;
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int Index0f(int[] collection, int find)
{
   int count = collection.Length;
   int index = 0;
   int position = -1; // если может быть ситуация, что искомого элемента нет совсем.

   while (index < count)
   {
        if (collection[index] == find)
        {
               position = index; // покажет последнее вхождение в массив заданного числа
               break; //если добавить эту строку - покажет первое вхождение
        }
        index++;
   }

    return position;
}

int[] array = new int[10];  //создай новый массив, в котором будет 10 элементов

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = Index0f(array, 4);
Console.WriteLine(pos);

