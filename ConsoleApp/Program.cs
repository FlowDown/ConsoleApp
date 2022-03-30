// See https://aka.ms/new-console-template for more information
string[] arr1 = {"hello","2","world","world",":-)" };
string[] arr2 = { "1234", "1567", "-2", "computer science" };
string[] arr3 = { "Russia", "Denmark", "Kazan" };

Console.WriteLine(GetString(arr1));

static string GetString(string [] arr)
{
    string strArr="";
    for(int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Строка {arr[i]} имеет длину: {arr[i].Length}");

        if (arr[i].Length <= 3)
        {
            
            strArr = strArr + (string)arr[i] + ",";
        } 
    }
    if (strArr != "") strArr = strArr.Remove(strArr.Length - 1);
    return strArr;
}
