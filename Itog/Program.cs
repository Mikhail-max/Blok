string[] Massiv (string[] array)
{
    string[] result = new string[array.Length];
    int realSize = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string str = array[i];
        if (str.Length <= 3)
        {
            result[realSize] = array[i];
            realSize++;
        }
    }
    return result;
}
void ShowArray (string[] array)
{
    for(int i = 0;i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

string[] array =
{
    "f",
    "ah",
    "cth",
    "abnd",
    "eojwe",
    "p"
};
