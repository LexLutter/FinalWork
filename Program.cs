string[] GetArray(int size) // Формирование строчного массива, ручным заполнением с консоли
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите любой текст для заполнения массива: \n");
        array[i] = Console.ReadLine();
        }
    return array;
}

int SumElements(string[] array, int limit) //Возвращает количество элементов массива, которые длинной меньше чем limit
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= limit) result++;
    }
    return result;
}

string[] SumElementsArray(string[] array, int limit) // Из заданного массива формируется массив с элементами длинной меньше limit
{   
    int size = SumElements(array, limit);
    string[] ResultArray = new string[size];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {   
        if (array[i].Length <= limit)
        {
            ResultArray[j] = array[i];
            j++;
        }
    }
    return ResultArray;
}

string[] array = GetArray(4);
Console.WriteLine($"Сформированный массив: [ {String.Join(", ", array)} ]");
//Console.WriteLine(SumElements(array, 3));
Console.WriteLine($"Массив с элементами длинной меньше 3: [ {String.Join(", ", SumElementsArray(array, 3))} ]");