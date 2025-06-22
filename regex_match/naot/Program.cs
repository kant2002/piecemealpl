using System;
using System.Text.RegularExpressions;

if (Regex.IsMatch("2025-06-22", "^\\d{4}-\\d{2}-\\d{2}$"))
{
    Console.WriteLine("The string matches the pattern!");
}
else
{
    Console.WriteLine("The string does not match the pattern.");
}
