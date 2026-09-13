## Cross language comparison table

| Component                 | C - Size (B) |Rust - Size (B) |C# - Size (B) |Go - Size (B) |
| ----------------------    | -------: |-------: |-------: |-------: |
| Runtime                   |   10,240 |  123,904 |  868,352 |1,038,336 |
| PrintLine                 |        0 |    7,168 |   65,024 |  504,320 |
| SumStrings                |    1,024 |      512 |        0 |        0 |
| ParseFloat                |      512 |   17,920 |   26,112 |   17,920 |
| StrReverse                |      512 |    1,536 |   16,896 |    2,560 |
| ToLower                   |    1,024 |    8,704 |    2,048 |   14,336 |
| StrEmpty                  |    1,024 |        0 |        0 |        0 |
| ArrayInit                 |        0 |      512 |    3,584 |    1,024 |
| CmdLineArgs               |        0 |    6,656 |        0 |      512 |
| CmdLineArgs2              |    4,608 |  510,976 |2,673,664 |   94,208 |
| ReadFile                  |    1,024 |   12,800 |  200,704 |  113,664 |
| WriteFile                 |      512 |   11,264 |  182,272 |   12,800 |
| CreateFile                |      512 |    8,704 |  181,248 |   13,312 |
| CreateDir                 |      512 |   16,896 |   14,336 |    8,192 |
| CreateDir2                |    1,536 |   16,896 |   14,336 |  113,664 |
| ZipFile                   |  189,440 |  916,992 |  971,776 |  280,064 |
| Win32Window               |    1,536 |    7,168 |  120,320 |  529,408 |
| Win32Button               |        0 |    1,536 |    1,024 |      512 |
| ProxyCallBaseline         |      512 |      512 |    1,536 |    4,608 |
| ProxyCall                 |        0 |        0 |  -66,560 |      512 |
| RandInt                   |      512 |   12,800 |      512 |   14,848 |
| RegexMatch                |  317,952 |1,547,264 |  550,400 |  285,184 |
| TcpSimple                 |    1,536 |   40,960 |  194,048 |  695,296 |
| CsvWrite                  |    2,560 |   47,104 |  192,000 |   28,672 |
| ParametersObjectBaseline  |    1,536 |   25,088 |   22,016 |   23,040 |
| ParametersObject          |     -512 |        0 |     -512 |    1,024 |
| JsonWrite                 |    7,168 |   10,752 |1,041,408 |  270,848 |


## C language basics

| Component                | Size (B)  |
| ------------------------ | --------: |
| Runtime                  |    10,240 |
| PrintLine                |         0 |
| SumStrings               |     1,024 |
| ParseFloat               |       512 |
| StrReverse               |       512 |
| ToLower                  |     1,024 |
| StrEmpty                 |     1,024 |
| ArrayInit                |         0 |
| CmdLineArgs              |         0 |
| CmdLineArgs2             |     4,608 |
| ReadFile                 |     1,024 |
| WriteFile                |       512 |
| CreateFile               |       512 |
| CreateDir                |       512 |
| CreateDir2               |     1,536 |
| ZipFile                  |   189,440 |
| Win32Window              |     1,536 |
| Win32Button              |         0 |
| ProxyCallBaseline        |       512 |
| ProxyCall                |         0 |
| RandInt                  |       512 |
| RegexMatch               |   317,952 |
| TcpSimple                |     1,536 |
| CsvWrite                 |     2,560 |
| ParametersObjectBaseline |     1,536 |
| ParametersObject         |      -512 |
| JsonWrite                |     7,168 |

## Rust language basics

| Component                | Size (B)  |
| ------------------------ | --------: |
| Runtime                  |   123,904 |
| PrintLine                |     7,168 |
| SumStrings               |       512 |
| ParseFloat               |    17,920 |
| StrReverse               |     1,536 |
| ToLower                  |     8,704 |
| StrEmpty                 |         0 |
| ArrayInit                |       512 |
| CmdLineArgs              |     6,656 |
| CmdLineArgs2             |   510,976 |
| ReadFile                 |    12,800 |
| WriteFile                |    11,264 |
| CreateFile               |     8,704 |
| CreateDir                |    16,896 |
| CreateDir2               |    16,896 |
| ZipFile                  |   916,992 |
| Win32Window              |     7,168 |
| Win32Button              |     1,536 |
| ProxyCallBaseline        |       512 |
| ProxyCall                |         0 |
| RandInt                  |    12,800 |
| RegexMatch               | 1,547,264 |
| TcpSimple                |    40,960 |
| CsvWrite                 |    47,104 |
| ParametersObjectBaseline |    25,088 |
| ParametersObject         |         0 |
| JsonWrite                |    10,752 |

## C# NativeAOT language basics

| Component                | Size (B)  |
| ------------------------ | --------: |
| Runtime                  |   868,352 |
| PrintLine                |    65,024 |
| SumStrings               |         0 |
| ParseFloat               |    26,112 |
| StrReverse               |    16,896 |
| ToLower                  |     2,048 |
| StrEmpty                 |         0 |
| ArrayInit                |     3,584 |
| CmdLineArgs              |         0 |
| CmdLineArgs2             | 2,673,664 |
| ReadFile                 |   200,704 |
| WriteFile                |   182,272 |
| CreateFile               |   181,248 |
| CreateDir                |    14,336 |
| CreateDir2               |    14,336 |
| ZipFile                  |   971,776 |
| Win32Window              |   120,320 |
| Win32Button              |     1,024 |
| ProxyCallBaseline        |     1,536 |
| ProxyCall                |   -66,560 |
| RandInt                  |       512 |
| RegexMatch               |   550,400 |
| TcpSimple                |   194,048 |
| CsvWrite                 |   192,000 |
| ParametersObjectBaseline |    22,016 |
| ParametersObject         |      -512 |
| JsonWrite                | 1,041,408 |

## Go language basics

| Component                | Size (B)  |
| ------------------------ | --------: |
| Runtime                  | 1,038,336 |
| PrintLine                |   504,320 |
| SumStrings               |         0 |
| ParseFloat               |    17,920 |
| StrReverse               |     2,560 |
| ToLower                  |    14,336 |
| StrEmpty                 |         0 |
| ArrayInit                |     1,024 |
| CmdLineArgs              |       512 |
| CmdLineArgs2             |    94,208 |
| ReadFile                 |   113,664 |
| WriteFile                |    12,800 |
| CreateFile               |    13,312 |
| CreateDir                |     8,192 |
| CreateDir2               |   113,664 |
| ZipFile                  |   280,064 |
| Win32Window              |   529,408 |
| Win32Button              |       512 |
| ProxyCallBaseline        |     4,608 |
| ProxyCall                |       512 |
| RandInt                  |    14,848 |
| RegexMatch               |   285,184 |
| TcpSimple                |   695,296 |
| CsvWrite                 |    28,672 |
| ParametersObjectBaseline |    23,040 |
| ParametersObject         |     1,024 |
| JsonWrite                |   270,848 |
