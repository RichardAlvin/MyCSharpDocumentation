/*using System.Text;

StringBuilder builder = new();
builder.AppendLine("Hello");
builder.AppendLine("World!");

Console.WriteLine(builder.ToString());*/

/*Console.Write("Hello ");
await Task.Delay(5000);
Console.WriteLine("World!");
await Task.Delay(5000);
Console.Write("Test!");*/

//Anonymus Type
var apple = new { Item = "apples", Price = 1.35 };
var onSale = apple with { Price = 0.79 };
Console.WriteLine(apple);
Console.WriteLine(apple);