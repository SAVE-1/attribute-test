# What is this project?
A little project, to test out how the ASP.Net is internally using Reflection to find classes with custom attributes, mimicking the way ASP.NET identifies controllers.

# How to run
Navigate to `./attribute-test/attribute-testing`, then run `dotnet run`

Or run the project in Visual Studio

## How all controllers are found from ./controllers
```csharp
var test = from cont in Assembly.GetExecutingAssembly().GetTypes()
            where cont.IsClass && cont.Namespace == Helper.GetProgramBaseNamespaceFormatted() + ".controllers"
            select cont;

List<string> s = new List<string>();

foreach (Type w in test)
{
  s.Add(w.Name);
}
```

## How all attribute marked controllers are found from ./controllers
```csharp
var test = from cont in Assembly.GetExecutingAssembly().GetTypes()
            where 
            cont.IsClass && 
            cont.Namespace == Helper.GetProgramBaseNamespaceFormatted() + ".controllers" &&
            cont.IsDefined(typeof(MyApiControllerAttribute))
            select cont;

List<string> s = new List<string>();

foreach (Type w in test)
{
  s.Add(w.Name);
}
```

## A small helper to help with formatting
```csharp
public static string GetProgramBaseNamespaceFormatted()
{
  Type t = typeof(Program);
  Assembly assem = Assembly.GetAssembly(t);
  return assem.GetName().Name.Replace('-', '_');
}
```
