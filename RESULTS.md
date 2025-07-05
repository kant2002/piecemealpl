## Cross language comparison table

| Component    | C - Size (B) |Rust - Size (B) |C# - Size (B) |Go - Size (B) |
| ------------    | -----: |-----: |-----: |-----: |
| Runtime              |   10,752 |  125,440 |1,044,480 |  863,744 |
| PrintLine            |        0 |   12,800 |   60,928 |  406,528 |
| SumStrings           |    1,024 |      512 |      512 |        0 |
| ParseFloat           |        0 |   17,408 |   26,112 |   18,432 |
| StrReverse           |        0 |    1,024 |   14,336 |    2,560 |
| ToLower              |      512 |   17,408 |    2,560 |   13,312 |
| StrEmpty             |      512 |        0 |        0 |     -512 |
| ArrayInit            |        0 |      512 |    3,584 |      512 |
| CmdLineArgs          |        0 |    7,168 |      512 |        0 |
| CmdLineArgs2         |    4,608 |  540,160 |2,309,120 |  101,888 |
| ReadFile             |      512 |   13,312 |  122,880 |  107,520 |
| WriteFile            |        0 |   12,288 |  106,496 |    7,680 |
| CreateFile           |        0 |    8,192 |  104,960 |    8,192 |
| CreateDir            |        0 |   16,896 |   13,824 |    4,096 |
| CreateDir2           |    1,536 |   16,896 |   13,824 |  107,008 |
| ZipFile              |  190,464 |  927,744 |  907,264 |  331,776 |
| Win32Window          |    1,536 |    9,216 |  113,152 |  440,320 |
| Win32Button          |        0 |      512 |    1,024 |    1,024 |
| ProxyCallBaseline    |      512 |    1,024 |    1,536 |    4,096 |
| ProxyCall            |        0 |        0 |  -62,464 |    1,024 |
| RandInt              |        0 |   13,312 |        0 |   84,480 |
| RegexMatch           |  311,808 |1,626,624 |  437,248 |  273,920 |
| TcpSimple            |    1,536 |   36,864 |  114,176 |  660,480 |
| CsvWrite             |    2,048 |   49,152 |  113,664 |   25,600 |
| ParametersObjectBaseline |    1,024 |   26,624 |   20,480 |   22,016 |
| ParametersObject     |        0 |        0 |      512 |      512 |
| JsonWrite            |    7,168 |   11,264 |  884,736 |  221,696 |


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
| RandInt    | 0 |
| RegexMatch | 311,808 |
| TcpSimple  | 1,536 |
| CsvWrite   | 2,048 |
| ParametersObjectBaseline| 1,024 |
| ParametersObject| 0 |
| JsonWrite  | 7,168 |

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
| RandInt    | 13,312 |
| RegexMatch | 1,626,624 |
| TcpSimple  | 36,864 |
| CsvWrite   | 49,152 |
| ParametersObjectBaseline| 26,624 |
| ParametersObject| 0 |
| JsonWrite  | 11,264 |

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
| RandInt    | 0 |
| RegexMatch | 437,248 |
| TcpSimple  | 114,176 |
| CsvWrite   | 113,664 |
| ParametersObjectBaseline| 20,480 |
| ParametersObject| 512 |
| JsonWrite  | 884,736 |

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
| RandInt    | 84,480 |
| RegexMatch | 273,920 |
| TcpSimple  | 660,480 |
| CsvWrite   | 25,600 |
| ParametersObjectBaseline| 22,016 |
| ParametersObject| 512 |
| JsonWrite  | 221,696 |
