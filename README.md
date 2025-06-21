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
- [ZipFile](./archivefile) Archive string into single file packaged into ZIP file.
- [CreateFile](./createfile) Create empty file with the given name.
- [CreateDir](./createdir) Create empty directory with the given name.
- [CreateDir2](./createdir2) Create empty directory with the given name and all subdirectories in path.
- [Win32Window](./win32_window) Create empty Win32 window.
- [Win32Button](./win32_button) Create Win32 window with one button.

# Abstractions cost
- [ProxyCallBaseline](./proxycall_baseline) 10 functions with single argument. Each of them called.
- [ProxyCall](./proxycall) 10 wrapper functions which pass single constant argument to 10 underlying functions defnied same was as in the ProxyCallBaseline. Estimate usage of the abstraction.

# Results

The 0 or negative numbers mean that I cannot reliably measure or guess that size. 
Obviosuly that feature have non zero size. Probably I overcalculate size of the runtime + minimal main functoin, and code which needed for that already alllocated.


## C language basics
| Component    | Size (B) |
| ------------ | -----: |
| Runtime    | 10,752 |
| PrintLine  | 0 |
| SumStrings | 1,024 |
| ParseFloat | 0 |
| StrReverse | 0 |
| ToLower    | 512 |
| StrEmpty   | 512 |
| ArrayInit  | 0 |
| CmdLineArgs| 0 |
| CmdLineArgs2| 4,608 |
| ReadFile   | 512 |
| WriteFile  | 0 |
| CreateFile | 0 |
| CreateDir  | 0 |
| CreateDir2 | 1,536 |
| ZipFile    | 190,464 |
| Win32Window| 1,536 |
| Win32Button| 0 |
| ProxyCallBaseline| 512 |
| ProxyCall  | 0 |

## Rust language basics
| Component    | Size (B) |
| ------------ | -----: |
| Runtime    | 125,440 |
| PrintLine  | 12,800 |
| SumStrings | 512 |
| ParseFloat | 17,408 |
| StrReverse | 1,024 |
| ToLower    | 17,408 |
| StrEmpty   | 0 |
| ArrayInit  | 512 |
| CmdLineArgs| 7,168 |
| CmdLineArgs2| 540,160 |
| ReadFile   | 13,312 |
| WriteFile  | 12,288 |
| CreateFile | 8,192 |
| CreateDir  | 16,896 |
| CreateDir2 | 16,896 |
| ZipFile    | 927,744 |
| Win32Window| 9,216 |
| Win32Button| 512 |
| ProxyCallBaseline| 1,024 |
| ProxyCall  | 0 |

## C# NativeAOT language basics
| Component    | Size (B) |
| ------------ | -----: |
| Runtime    | 1,044,480 |
| PrintLine  | 60,928 |
| SumStrings | 512 |
| ParseFloat | 26,112 |
| StrReverse | 14,336 |
| ToLower    | 2,560 |
| StrEmpty   | 0 |
| ArrayInit  | 3,584 |
| CmdLineArgs| 512 |
| CmdLineArgs2| 2,309,120 |
| ReadFile   | 122,880 |
| WriteFile  | 106,496 |
| CreateFile | 104,960 |
| CreateDir  | 13,824 |
| CreateDir2 | 13,824 |
| ZipFile    | 907,264 |
| Win32Window| 113,152 |
| Win32Button| 1,024 |
| ProxyCallBaseline| 1,536 |
| ProxyCall  | -62,464 |

## Go language basics
| Component    | Size (B) |
| ------------ | -----: |
| Runtime    | 863,744 |
| PrintLine  | 406,528 |
| SumStrings | 0 |
| ParseFloat | 18,432 |
| StrReverse | 2,560 |
| ToLower    | 13,312 |
| StrEmpty   | -512 |
| ArrayInit  | 512 |
| CmdLineArgs| 0 |
| CmdLineArgs2| 101,888 |
| ReadFile   | 107,520 |
| WriteFile  | 7,680 |
| CreateFile | 8,192 |
| CreateDir  | 4,096 |
| CreateDir2 | 107,008 |
| ZipFile    | 331,776 |
| Win32Window| 440,320 |
| Win32Button| 1,024 |
| ProxyCallBaseline| 4,096 |
| ProxyCall  | 1,024 |