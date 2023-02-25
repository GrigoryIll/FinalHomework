void StringValues(string[] args)
{
    string[] values = {"hello", "2", "world", ":=)"};
    for (int i = 0; i < values.Length; i++)
    {
        if (values[i].Length <= 3)
        {
            Console.Write(values[i] + " ");
        }
    }
}
StringValues(args);
