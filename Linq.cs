using System;
using System.Linq;
class Program
{
 static void Main()
 {
 string[] words = {"Nada", "Tuwaiq", "LINQ", "cat", "world"};

 //Get only short words
 var myLinqQuery = from word in words
                   where word.Length <= 5 
                   select word;
 

 //Print each word out
 foreach (var word in myLinqQuery )
 {
 Console.WriteLine(word);
 } 
Console.ReadLine(); 
         }
  }
