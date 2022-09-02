﻿string text = @"Historically, the world of data and the world of objects" +
  @" have not been well integrated. Programmers work in C# or Visual Basic" +
  @" and also in SQL or XQuery. On the one side are concepts such as classes," +
  @" objects, fields, inheritance, and .NET APIs. On the other side" +
  @" are tables, columns, rows, nodes, and separate languages for dealing with" +
  @" them. Data types often require translation between the two worlds; there are" +
  @" different standard functions. Because the object world has no notion of query, a" +
  @" query can only be represented as a string without compile-time type checking or" +
  @" IntelliSense support in the IDE. Transferring data from SQL tables or XML trees to" +
  @" objects in memory is often tedious and error-prone.";

string searchTerm = "data";

//Convert the string into an array of words  
string[] source = text.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

// Create the query.  Use the InvariantCultureIgnoreCase comparision to match "data" and "Data"
var matchQuery = from word in source
                 where word.Equals(searchTerm, StringComparison.InvariantCultureIgnoreCase)
                 select word;

// Count the matches, which executes the query.  
int wordCount = matchQuery.Count();
Console.WriteLine("{0} occurrences(s) of the search term \"{1}\" were found.", wordCount, searchTerm);

// Keep console window open in debug mode  
Console.WriteLine("Press any key to exit");
Console.ReadKey();