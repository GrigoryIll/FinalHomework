void StringValues()
{
    int sizeArray2 = 0;
    string[] array1 = {"hello", "2", "world", ":=)"};
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        sizeArray2++;
    }

    string[] array2 = new string[sizeArray2];
    int i2 = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[i2++] = array1[i];         
        }
    }
    Console.Write("[" + string.Join(", ", array2) + "]");
}

StringValues();