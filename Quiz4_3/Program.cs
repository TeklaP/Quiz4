//დაწერეთ პროგრამა, რომელიც სტრინგში (წინადადებაში) იპოვის Uppercaseიან სიტყვებს და დაბეჭდავს მათ
using System; 
using System.Linq;

Console.WriteLine("Enter the sentence: ");
string newString = Console.ReadLine()!;

string[] words = newString!.Split(' ');

var upperCaseWords = words.Where(x => x == x.ToUpper());

foreach (string word in upperCaseWords)
{
    Console.WriteLine(word);
}



