/*
  Задача: Написать программу, которая из имеющегося массива строк формирует массив из 
  строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести 
  с клавиатуры, либо задать на старте выполнения алгоритма. При решении не 
  рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

    Примеры:
  ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
  ["1234", "1567", "-2", "computer science"] -> ["-2"]
  ["Russia", "Denmark", "Kazan"] -> []
*/

Console.WriteLine("Введите значения через запятую:");
string stringIn = Console.ReadLine();
string[] stringsArrayFirst = GetStringsArray(stringIn);
int lengthArray = GetLength(stringsArrayFirst);
string[] resultArray = GetNewStringsArray(stringsArrayFirst, lengthArray);

Console.Write("Вы ввели массив строк ");
PrintStringArray(stringsArrayFirst);
Console.Write("В этом массиве строк, длина которых меньше либо равна 3 символа:");
PrintStringArray(resultArray);

// возвращает массив строк
string[] GetStringsArray(string inputText)
{
  char[] separators = new char[] { ' ', '.', ',' };
  return inputText.Split(separators, StringSplitOptions.RemoveEmptyEntries);
}

// получаем длину массива
int GetLength(string[] strArray)
{
  int lengthStringsArray = 0;
  for (int i = 0; i < strArray.Length; i++)
  {
    if (strArray[i].Length <= 3) lengthStringsArray++;
    else continue;
  }
  return lengthStringsArray;
}

// возвращает новый массив строк, длина которых меньше либо равна 3 символа
string[] GetNewStringsArray(string[] strArray, int lengthArray)
{
  string[] resultArray = new string[lengthArray];

  for (int i = 0; i < strArray.Length; i++)
  {
    if (strArray[i].Length <= 3) resultArray[i] = strArray[i];
    else continue;
  }

  return resultArray;
}

void PrintStringArray(string[] array)
{
  Console.Write($"[");
  for (int i = 0; i < array.Length; i++)
  {
    if (i == array.Length - 1) Console.Write($"{array[i]}");
    else Console.Write($"{array[i]}, ");
  }
  Console.Write($"]");
}

