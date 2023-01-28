string[] ThreeArray(int size, string[] array)
{
    string[] finalArray = new string[size];
    int j=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length<4) 
        {
            finalArray[j]=array[i];
            j++;
        }
    }
    return finalArray;
}

int CountThreeArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length<4) count++;
    }
    return count;
}

string[] FillArray(int n) 
{
    string[] array = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите {i+1}-й элемент массива: ");
            array[i] = Console.ReadLine();
        }
    return array;
}

int EnterData(string text) 
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int arraySize = EnterData("Введите размер массива: ");
string[] array = FillArray(arraySize);
int numThreeSymbols = CountThreeArray(array);
string[] resultArray = ThreeArray(numThreeSymbols, array);

Console.WriteLine();
for (int i = 0; i < numThreeSymbols; i++)
{
    Console.WriteLine(resultArray[i]);    
}
