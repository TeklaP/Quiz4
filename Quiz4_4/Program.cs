//დაწერეთ პროგრამა, რომელიც დააბრუნებს მასივში x-დან y შუალედში ელემენტებს 

using System;
using System.Linq;

int[] newArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2 };
var arraySegment = new ArraySegment<int>(newArray, 5, 4);

foreach (var value in arraySegment)
{
    Console.WriteLine(value);
}

