﻿string[] myArray = {"I", "quick", "brown", "win", "jumps", "and", "tennis", "lazy", "I","those","am","the","man"};
PrintArray(myArray);
Console.WriteLine();
Console.WriteLine("Новый массив состоящий только из строк длиной <= 3 символа:");
PrintArray(NewShortArray(myArray));


string[] NewShortArray(string[] array)
{
    string[] shotArray = new string[array.Length];
    int j = 0;  
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        {
            shotArray[j] = array[i];
            j++;
        } 
    }
    Array.Resize(ref shotArray, j);
    return shotArray;
}


void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
}