using System.CommandLine;
using System.CommandLine.Invocation;

var f = new Option<string>("-f", "filename");
var i = new Option<int?>("-i", "option");
var l = new Option<int?>("-l", "option");
var r = new Option<int?>("-r", "option");
var rootCommand = new RootCommand("Test")
{
    f,
    i,
    l,
    r,
};

rootCommand.SetAction(parseResult =>
{
    var (fValue, iValue, lValue, rValue) = (parseResult.GetValue(f), parseResult.GetValue(i), parseResult.GetValue(l), parseResult.GetValue(r));
    if (!string.IsNullOrEmpty(fValue)) 
    {
        Console.WriteLine($"filename : {fValue}");
    }
    if (iValue.HasValue)
    {
        Console.WriteLine($"option : {iValue.Value}");
    }
    if (lValue.HasValue)
    {
        Console.WriteLine($"option : {lValue.Value}");
    }
    if (rValue.HasValue)
    {
        Console.WriteLine($"option : {rValue.Value}");
    }

});

ParseResult parseResult = rootCommand.Parse(args);
return parseResult.Invoke();
