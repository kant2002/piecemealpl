## Cross language comparison table

| Component                 | C - Size (B) |Rust - Size (B) |C# - Size (B) |Go - Size (B) |
| ----------------------    | -------: | -------: | -------: | -------: | 
| Runtime                   |   10,240 |  123,904 |  868,352 |1,228,800 |
| PrintLine                 |        0 |    7,168 |   65,024 |  442,368 |
| SumStrings                |    1,024 |      512 |        0 |        0 |
| ParseFloat                |      512 |   17,920 |   26,112 |   17,920 |
| ParseInt                  |        0 |        0 |    1,024 |   23,040 |
| StrReverse                |      512 |    1,536 |   16,896 |    1,536 |
| StrReplace                |      512 |    2,560 |    7,168 |   11,776 |
| ToLower                   |    1,024 |    8,704 |    2,048 |   14,336 |
| StrEmpty                  |    1,024 |        0 |        0 |        0 |
| ArrayInit                 |        0 |      512 |    3,584 |    1,024 |
| CmdLineArgs               |        0 |    6,656 |        0 |        0 |
| CmdLineArgs2              |    4,608 |  510,976 |1,896,448 |   89,088 |
| ReadFile                  |    1,024 |   12,800 |  200,704 |  115,200 |
| WriteFile                 |      512 |   11,264 |  182,272 |   14,848 |
| CreateFile                |      512 |    8,704 |  181,248 |   15,360 |
| CreateDir                 |      512 |   16,896 |   14,336 |    9,728 |
| CreateDir2                |    1,536 |   16,896 |   14,336 |  113,664 |
| DeleteFile                |      512 |   10,240 |    6,144 |   11,264 |
| ExistsFile                |      512 |    7,168 |   10,240 |  108,544 |
| CopyFile                  |    1,536 |    1,536 |   13,312 |   34,816 |
| ZipFile                   |  189,440 |  916,992 |  971,776 |  329,216 |
| Win32Window               |    1,536 |    7,168 |  120,320 |  483,840 |
| Win32Button               |        0 |    1,536 |    1,024 |        0 |
| ProxyCallBaseline         |      512 |      512 |    1,536 |    4,608 |
| ProxyCall                 |        0 |        0 |  -66,560 |      512 |
| RandInt                   |      512 |   12,800 |      512 |   13,312 |
| RegexMatch                |  317,952 |1,547,264 |  550,400 |  303,104 |
| TcpSimple                 |    1,536 |   40,960 |  194,048 |  679,936 |
| CsvWrite                  |    2,560 |   47,104 |  192,000 |   31,232 |
| ParametersObjectBaseline  |    1,536 |   25,088 |   22,016 |   22,016 |
| ParametersObject          |     -512 |        0 |     -512 |      512 |
| JsonWrite                 |    7,168 |   10,752 |1,041,408 |1,071,616 |


## C language basics

| Component                | Size (B)  |
| ------------------------ | --------: |
| Runtime                  |    10,240 |
| PrintLine                |         0 |
| SumStrings               |     1,024 |
| ParseFloat               |       512 |
| ParseInt                 |         0 |
| StrReverse               |       512 |
| StrReplace               |       512 |
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
| DeleteFile               |       512 |
| ExistsFile               |       512 |
| CopyFile                 |     1,536 |
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
| ParseInt                 |         0 |
| StrReverse               |     1,536 |
| StrReplace               |     2,560 |
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
| DeleteFile               |    10,240 |
| ExistsFile               |     7,168 |
| CopyFile                 |     1,536 |
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
| ParseInt                 |     1,024 |
| StrReverse               |    16,896 |
| StrReplace               |     7,168 |
| ToLower                  |     2,048 |
| StrEmpty                 |         0 |
| ArrayInit                |     3,584 |
| CmdLineArgs              |         0 |
| CmdLineArgs2             | 1,896,448 |
| ReadFile                 |   200,704 |
| WriteFile                |   182,272 |
| CreateFile               |   181,248 |
| CreateDir                |    14,336 |
| CreateDir2               |    14,336 |
| DeleteFile               |     6,144 |
| ExistsFile               |    10,240 |
| CopyFile                 |    13,312 |
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
| Runtime                  | 1,228,800 |
| PrintLine                |   442,368 |
| SumStrings               |         0 |
| ParseFloat               |    17,920 |
| ParseInt                 |    23,040 |
| StrReverse               |     1,536 |
| StrReplace               |    11,776 |
| ToLower                  |    14,336 |
| StrEmpty                 |         0 |
| ArrayInit                |     1,024 |
| CmdLineArgs              |         0 |
| CmdLineArgs2             |    89,088 |
| ReadFile                 |   115,200 |
| WriteFile                |    14,848 |
| CreateFile               |    15,360 |
| CreateDir                |     9,728 |
| CreateDir2               |   113,664 |
| DeleteFile               |    11,264 |
| ExistsFile               |   108,544 |
| CopyFile                 |    34,816 |
| ZipFile                  |   329,216 |
| Win32Window              |   483,840 |
| Win32Button              |         0 |
| ProxyCallBaseline        |     4,608 |
| ProxyCall                |       512 |
| RandInt                  |    13,312 |
| RegexMatch               |   303,104 |
| TcpSimple                |   679,936 |
| CsvWrite                 |    31,232 |
| ParametersObjectBaseline |    22,016 |
| ParametersObject         |       512 |
| JsonWrite                | 1,071,616 |
