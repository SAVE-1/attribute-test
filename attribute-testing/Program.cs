// See https://aka.ms/new-console-template for more information
using attribute_testing;

Console.WriteLine("-- Controllers --");
foreach (string s in Helper.GetControllers())
{
    Console.WriteLine(s);
}

Console.WriteLine("-- Controllers with attributes --");
foreach (string s in Helper.GetControllersWithCorrectAttributes())
{
    Console.WriteLine(s);
}

