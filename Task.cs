Console.Clear(); 
string[] arr = {"hellow","2",":-)", "345",}; 
string[] newArr ={};
for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"{arr[i]}, ");
}
Console.Write($"-> ");
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length < 4)
    {
        Array.Resize(ref newArr, newArr.Length+1);
        newArr[newArr.Length-1] = arr[i];
    }    
}
for (int j = 0; j < newArr.Length; j++)
{
    Console.Write($"{newArr[j]}, ");
}