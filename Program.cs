int ShortStringAmount(string[] array)
{
  int result = 0;
  for (int i = 0; i < array.Length; i++)
    if (array[i].Length <= 3) result++;
  return result;
}

string[] FormArrayOfShortStrings(string[] array)
{
  string[] newArray = new string[ShortStringAmount(array)];
  int counter = 0;
  for (int i = 0; i < array.Length; i++)
    if (array[i].Length <= 3)
    {
      newArray[counter] = array[i];
      counter++;
    }
  return newArray;
}

void ShowStringArray(string[] array)
{
  Console.Write("[");
  for (int i = 0; i < array.Length; i++) Console.Write($"\"{array[i]}\" ");
  Console.Write("]");
  Console.WriteLine();
}

string[] CreateStringArray()
{
  Console.Write("Input length of string array: ");
  int length = Convert.ToInt32(Console.ReadLine());
  string[] array = new string[length];
  for (int i = 0; i < length; i++)
  {
    Console.Write($"input {i+1} element of string array: ");
    array[i] = Console.ReadLine();
  }
  return array;
}


//string[] arrayToWork = { "asdf", "2345" };
string[] arrayToWork = CreateStringArray();
ShowStringArray(arrayToWork);
string[] resultArray = FormArrayOfShortStrings(arrayToWork);
ShowStringArray(resultArray);