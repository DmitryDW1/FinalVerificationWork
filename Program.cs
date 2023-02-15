// Creating an array based on user parameters
string[] CreateArrayString()
{
    Console.WriteLine("Input a length of array: ");
    int length = Convert.ToInt32(Console.ReadLine());

    string[] array = new string[length];
    for (int i = 0; i < length; i++)
    {
        
        Console.WriteLine($"Type something. This will be an array element {i+1}: ");
        
        array[i] = Console.ReadLine();
        if (array[i] == null)
        {
            array[i] = "Null";
        }
        
    }
    Console.WriteLine();
    return array;
}
// We show the original and processed array on the screen
void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write("\t" + array[i] + "\t");
}
// Processing the array according to the specified parameters
string[] CreateSortedArrayString(string[] array, int elementArrayLength)
{
    string[] sortedArray = new string[elementArrayLength];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= elementArrayLength)
        {
            sortedArray[j] = array[i];
            j++;
        }
    }
    Console.WriteLine();
    return sortedArray;
}

string[] arrayString = CreateArrayString();
Console.WriteLine("Here is the original array");
ShowArray(arrayString);

string[] sortedArrayString = CreateSortedArrayString(arrayString, 3);
Console.WriteLine("Here is the processed array");
ShowArray(sortedArrayString);