Console.Write("Enter the size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] CreateArray()
{
    string[] array = new string [size];
    for (int index = 0; index < size; index++)
    {
        Console.Write($"Enter the string {index}: ");
        array[index] = Convert.ToString(Console.ReadLine());
    }
    return array;
}
string[] arr = CreateArray();
void CreateNewArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {   
        if (arr[i].Length <= 3)
        {
            Console.Write($"{arr[i]} \t");
        }
    }
    Console.WriteLine();
}
CreateNewArray(arr);
