int size = 6;
int n = 3;
string[] arrayOne = new string[size];
Console.WriteLine($"Введите набор символов, означающих значение строкового элемента массива, {size} раз через enter, без пробелов");
//FillArray(arrayOne);
FillArrayRandom(arrayOne);
Console.Clear();
PrintArray(arrayOne);
Console.WriteLine();
Console.WriteLine($"Новый массив, содержащий элементы, размер которых меньше либо равен {n}:");
if (GetSizeSecondArray(arrayOne) == 0){Console.WriteLine("искомых элементов массива не найдено");}
else
{
    string[] arrayTwo = TransferElements(arrayOne);
    PrintArray(arrayTwo);
}

void FillArrayRandom(string[] arr)
{
    Random rand = new Random();
    string AllSymbol = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!$&";
    for (int i = 0; i < size; i++)
    {
        int randElemSize = rand.Next(1,7);
        for (int j = 0; j < randElemSize; j++)
        {
            arr[i] += AllSymbol[rand.Next(0,AllSymbol.Length)];
        }
    }
}

void FillArray (string[] arr)
{
    for (int i = 0; i < size; i++)
    {
        arr[i] = Console.ReadLine() ?? "";
    }
}

void PrintArray (string[] arr)
{
    int arrLendth = arr.Length;
    Console.Write ("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write (arr[i] + " ");
    }
    Console.Write ("]");
}

int GetSizeSecondArray(string[] arr)
{
    int secondSize = 0;
    for (int i = 0; i < size; i++)
    {
        if(arr[i].Length <= n)
        {
            secondSize++;
        }
    }
    return secondSize; 
}

string[] TransferElements(string[] arr)
{
    string[] arrayTwo = new string[GetSizeSecondArray(arrayOne)];
    for (int i = 0, j = 0; i < size ; i++)
    {
        if(arr[i].Length <= n)
        {
            arrayTwo[j] = arr[i];
            j++;
        }
    }
    return arrayTwo ; 
}