// See https://aka.ms/new-console-template for more information

//დაწერეთ პროგრამა, რომელიც მასივში დაითვლის თითოეული ელემენტის რაოდენობას 
using System;
using System.Linq;

Console.WriteLine("Enter the length of the array: ");

int arrLen=Int32.Parse(Console.ReadLine()!);

int[] newArray = new int[arrLen];
Console.WriteLine("Enter elements of the array: ");

for (int i = 0; i < arrLen; i++)
{
    newArray[i] = Int32.Parse(Console.ReadLine());
}

var distinctValues = newArray.Distinct().ToArray();
for (int i = 0; i < distinctValues.Length; i++)
{
    var count = newArray.Count(x => x == distinctValues[i]);
    Console.WriteLine("The count of element {0} is {1}", distinctValues[i], count);
}




