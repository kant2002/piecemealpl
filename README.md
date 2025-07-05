Example projects for measuring the code size of the different primitive software operations
==========================

The goal of this experiement is to measure, what primitive software concepts weight in the byte code.
I attempt to have more or less idiomatic code, and not something which people will use when they optimize for size.
Let's call it typical low effor code.

Right now I have only lowlevel operation in the code. But really would like to measure different level of abstractions.
Let's say what it take to ZIP archive, how much code needed to make 1 HTTP request, how much code needed to create empty UI window,
what code takes to make button, etc. It can be ambiguous, but if start with simple things, and craft sentences more detailed we can 
probably capture enough interesting information to guess why our software sometimes can take hundreds of megabytes, and why 
our dependencies in some languages can take gigabytes even for relatively simple applications. To have more concrete explanation, 
and not abstract "because we don't care about dependencies". That's not actionable IMO.

If you agree to help with this very mundane process, please submit PR.

[Українською](./README_uk.md)

# How to run
```
./measure.ps1
```

# Components

- [PrintLine](./printline) Print line to the console.
- [SumStrings](./sum_strings) The perform concatenation of two string types in the language.
- [ParseFloat](./parse_float) Parse string with float value into float32 datatype.
- [StrReverse](./strreverse) Reverse constant string
- [ToLower](./tolower) Convert string to lowercase using default locale parameters in the langugage.
- [StrEmpty](./strempty) Check that string is empty.
- [ArrayInit](./arrayinit) Initialize array of 100 bytes and print all 100 of them.
- [CmdLineArgs](./cmdlineargs) Printing all passed command line args
- [CmdLineArgs2](./cmdlineargs2) Parse 4 command line arguments and print them.
- [ReadFile](./readfile) Read file to the console
- [WriteFile](./writefile) Write string content to file
- [CreateFile](./createfile) Create empty file with the given name.
- [CreateDir](./createdir) Create empty directory with the given name.
- [CreateDir2](./createdir2) Create empty directory with the given name and all subdirectories in path.
- [ZipFile](./archivefile) Archive string into single file packaged into ZIP file.
- [Win32Window](./win32_window) Create empty Win32 window.
- [Win32Button](./win32_button) Create Win32 window with one button.
- [RandInt](./randint) Generate pseudo random number
- [RegexMatch](./regex_match) Check if string match with pattern defined as regular expression
- [TcpSimple](./tcp_simple) The TCP server which wrote Helo World to connected client and close the connection.
- [CsvWrite](./csv_write) Write simple CSV file with 3 column and proper escaping. All data is hardcoded.

# Abstractions cost
- [ProxyCallBaseline](./proxycall_baseline) 10 functions with single argument. Each of them called.
- [ProxyCall](./proxycall) 10 wrapper functions which pass single constant argument to 10 underlying functions defnied same was as in the ProxyCallBaseline. Estimate usage of the abstraction.
- [ParametersObjectBaseline](./parameterobjects_baseline) 10 functions which accept different parameters and use them.
- [ParametersObject](./parameterobjects) 10 functions which accept different parameters as structs and use them.

# Results

The 0 or negative numbers mean that I cannot reliably measure or guess that size. 
Obviosuly that feature have non zero size. Probably I overcalculate size of the runtime + minimal main functoin, and code which needed for that already alllocated.

[Results](./RESULTS.md)]