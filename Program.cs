string[] elementaryArray = FillArray();
string[] resultArray = GenerateNewArray(elementaryArray);
string firstArray = PrintArray(elementaryArray);
string secondArray = PrintArray(resultArray);
Console.WriteLine(firstArray + " -> " + secondArray);
string[] FillArray()
{
    Console.WriteLine("Введите строки разделенные пробелом ");
    string? enterSymbols = Console.ReadLine();
    if (enterSymbols == null) { enterSymbols = ""; };
    char[] separators = new char[] {' ' };
    string[] elementaryArray = enterSymbols.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return elementaryArray;
}
string PrintArray(string[] elementaryArray)
{
    string stringArray = "[";
    for (int i = 0; i < elementaryArray.Length; i++)
    {
        if (i == elementaryArray.Length - 1)
        {
            stringArray += $"\"{elementaryArray[i]}\"";
            break;
        }
        stringArray += ($"\"{elementaryArray[i]}\", ");
    }
    stringArray += "]";
    return stringArray;
}
int CountStringSymbols(string[] elementaryArray)
{
    int counter = 0;
    foreach (string item in elementaryArray)
    {
        if (item.Length <= 3)
        {
            counter++;
        }
    }
    return counter;
}
string[] GenerateNewArray(string[] elementaryArray)
{
    int resultArrayLength = CountStringSymbols(elementaryArray);
    string[] resultArray = new string[resultArrayLength];
    int i = 0;
    foreach (string item in elementaryArray)
    {
        if (item.Length <= 3)
        {
            resultArray[i] = item;
            i++;
        }
    }
    return resultArray;
}
