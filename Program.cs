
string[] arrInput = new string[5] {"123", "23", "hello", "world", "res"};
string[] arrTemp = new string[arrInput.Length];
int count = 0;
void SecondArray(string[] arrInput, string[] arrTemp)
{
    int count = 0;
    for (int i = 0; i < arrInput.Length; i++)
    {
    if(arrInput[i].Length <= 3)
        {
        arrTemp[count] = arrInput[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArray(arrInput, arrTemp);
PrintArray(arrTemp)
