//დაწერეთ პროგრამა, რომელიც დაითვლის სტრინგში თითოეული სიმბოლოს რაოდენობას 
using System; 
using System.Linq;

Console.WriteLine("Enter the string: ");
string? newString = Console.ReadLine();

char[] stringChar = newString.ToCharArray();

var distElements = stringChar.Distinct().ToArray();
for (int i = 0; i < distElements.Length; i++)
{
    var count = stringChar.Count(x => x==distElements[i]);
    Console.WriteLine("The count of symbol {0} is {1}", distElements[i], count);
}