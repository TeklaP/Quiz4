//დაწერეთ პროგრამა, რომელიც დაბეჭდავს სტრინგში ყველაზე განმეორებად სიმბოლოს 

using System;
using System.Linq;

string newString = "students";
char[] charArray = newString.ToCharArray();

var mostFrequent = charArray.GroupBy(x => x).OrderByDescending(y => y.Count()).Select(y => y.Key).First();

Console.WriteLine("The most frequent character in the string is {0}", mostFrequent);
