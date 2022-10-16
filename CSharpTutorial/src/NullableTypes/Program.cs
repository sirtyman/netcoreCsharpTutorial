
Nullable<int> i = null;  // or int?i = null

if (i.HasValue)
{
    Console.WriteLine("{}", i);
}
else
{
    Console.WriteLine("i is null");
}