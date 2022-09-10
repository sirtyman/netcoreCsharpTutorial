using System.Text;


var strBuilder = new StringBuilder();


strBuilder.Append("Ala");
var ints = new int[] {1, 2, 3, 4, 5};
strBuilder.AppendJoin(", ", ints);

Console.WriteLine(strBuilder);
