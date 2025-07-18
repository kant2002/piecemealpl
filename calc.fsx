#r "nuget: MathNet.Numerics, 5.0.0"
#r "nuget: MathNet.Numerics.FSharp, 5.0.0"

// Illustrates solving systems of simultaneous linear
// equations using the DenseMatrix and LUDecomposition classes 
// in the Numerics.NET.LinearAlgebra namespace of Numerics.NET.

#light

open System

open MathNet.Numerics
// The DenseMatrix and LUDecomposition classes reside in the 
// Numerics.NET.LinearAlgebra namespace.
open MathNet.Numerics.LinearAlgebra

// The license is verified at runtime. We're using a 30 day trial key here.
// For more information, see:
//     https://numerics.net/trial-key
//let licensed = Numerics.NET.License.Verify("64542-18980-57619-62268")

// A system of simultaneous linear equations is
// defined by a square matrix A and a right-hand
// side B, which can be a vector or a matrix.
//
// You can use any matrix type for the matrix A.
// The optimal algorithm is automatically selected.

module App =
    [<Literal>]
    let Baseline = 0
    [<Literal>]
    let SumStrings = 1
    [<Literal>]
    let ParseFloat = 2
    [<Literal>]
    let StrReverse = 3
    [<Literal>]
    let ToLower = 4
    [<Literal>]
    let StrEmpty = 5
    [<Literal>]
    let ArrayInit = 6
    [<Literal>]
    let CmdLineArgs = 7
    [<Literal>]
    let ReadFile = 8
    [<Literal>]
    let ZipFile = 9
    [<Literal>]
    let CreateFile = 10
    [<Literal>]
    let Win32Window = 11
    [<Literal>]
    let Win32Button = 12
    [<Literal>]
    let PrintLine = 13
    [<Literal>]
    let ProxyCallBaseline = 14
    [<Literal>]
    let ProxyCall = 15
    [<Literal>]
    let CmdLineArgs2 = 16
    [<Literal>]
    let CreateDir = 17
    [<Literal>]
    let CreateDir2 = 18
    [<Literal>]
    let WriteFile = 19
    [<Literal>]
    let RandInt = 20
    [<Literal>]
    let RegexMatch = 21
    [<Literal>]
    let TcpSimple = 22
    [<Literal>]
    let CsvWrite = 23
    [<Literal>]
    let ParametersObjectBaseline = 24
    [<Literal>]
    let ParametersObject = 25
    [<Literal>]
    let JsonWrite = 26

module Components =
    [<Literal>] 
    let Runtime = 0
    [<Literal>]
    let SumStrings = 1
    [<Literal>]
    let ParseFloat = 2
    [<Literal>]
    let StrReverse = 3
    [<Literal>]
    let ToLower = 4
    [<Literal>]
    let StrEmpty = 5
    [<Literal>]
    let ArrayInit = 6
    [<Literal>]
    let CmdLineArgs = 7
    [<Literal>]
    let ReadFile = 8
    [<Literal>]
    let ZipFile = 9
    [<Literal>]
    let CreateFile = 10
    [<Literal>]
    let Win32Window = 11
    [<Literal>]
    let Win32Button = 12
    [<Literal>]
    let PrintLine = 13
    [<Literal>]
    let ProxyCallBaseline = 14
    [<Literal>]
    let ProxyCall = 15
    [<Literal>]
    let CmdLineArgs2 = 16
    [<Literal>]
    let CreateDir = 17
    [<Literal>]
    let CreateDir2 = 18
    [<Literal>]
    let WriteFile = 19
    [<Literal>]
    let RandInt = 20
    [<Literal>]
    let RegexMatch = 21
    [<Literal>]
    let TcpSimple = 22
    [<Literal>]
    let CsvWrite = 23
    [<Literal>]
    let ParametersObjectBaseline = 24
    [<Literal>]
    let ParametersObject = 25
    [<Literal>]
    let JsonWrite = 26

let m = Matrix<float>.Build.Dense(27 (*apps*), 27 (*components*))
m[App.Baseline, Components.Runtime] <- 1.0

m[App.SumStrings,Components.Runtime] <- 1.0
m[App.SumStrings,Components.PrintLine] <- 1.0
m[App.SumStrings,Components.SumStrings] <- 1.0

m[App.ParseFloat,Components.Runtime] <- 1.0
m[App.ParseFloat,Components.PrintLine] <- 1.0
m[App.ParseFloat,Components.ParseFloat] <- 1.0

m[App.StrReverse,Components.Runtime] <- 1.0
m[App.StrReverse,Components.PrintLine] <- 1.0
m[App.StrReverse,Components.StrReverse] <- 1.0

m[App.ToLower,Components.Runtime] <- 1.0
m[App.ToLower,Components.PrintLine] <- 1.0
m[App.ToLower,Components.ToLower] <- 1.0

m[App.StrEmpty,Components.Runtime] <- 1.0
m[App.StrEmpty,Components.PrintLine] <- 1.0
m[App.StrEmpty,Components.StrEmpty] <- 1.0

m[App.ArrayInit,Components.Runtime] <- 1.0
m[App.ArrayInit,Components.PrintLine] <- 1.0
m[App.ArrayInit,Components.ArrayInit] <- 1.0

m[App.CmdLineArgs,Components.Runtime] <- 1.0
m[App.CmdLineArgs,Components.PrintLine] <- 1.0
m[App.CmdLineArgs,Components.CmdLineArgs] <- 1.0

m[App.ReadFile,Components.Runtime] <- 1.0
m[App.ReadFile,Components.PrintLine] <- 1.0
m[App.ReadFile,Components.ReadFile] <- 1.0

m[App.ZipFile,Components.Runtime] <- 1.0
m[App.ZipFile,Components.PrintLine] <- 1.0
m[App.ZipFile,Components.CreateFile] <- 1.0
m[App.ZipFile,Components.ZipFile] <- 1.0

m[App.CreateFile,Components.Runtime] <- 1.0
m[App.CreateFile,Components.PrintLine] <- 1.0
m[App.CreateFile,Components.CreateFile] <- 1.0

m[App.Win32Window,Components.Runtime] <- 1.0
//m[App.Win32Window,Components.PrintLine] <- 1.0
m[App.Win32Window,Components.Win32Window] <- 1.0

m[App.Win32Button,Components.Runtime] <- 1.0
//m[App.Win32Button,Components.PrintLine] <- 1.0
m[App.Win32Button,Components.Win32Window] <- 1.0
m[App.Win32Button,Components.Win32Button] <- 1.0

m[App.PrintLine,Components.Runtime] <- 1.0
m[App.PrintLine,Components.PrintLine] <- 1.0

m[App.ProxyCallBaseline,Components.Runtime] <- 1.0
m[App.ProxyCallBaseline,Components.PrintLine] <- 1.0
m[App.ProxyCallBaseline,Components.ProxyCallBaseline] <- 1.0

m[App.ProxyCall,Components.Runtime] <- 1.0
m[App.ProxyCall,Components.PrintLine] <- 1.0
m[App.ProxyCall,Components.ProxyCallBaseline] <- 1.0
m[App.ProxyCall,Components.ProxyCall] <- 1.0

m[App.CmdLineArgs2,Components.Runtime] <- 1.0
m[App.CmdLineArgs2,Components.PrintLine] <- 1.0
m[App.CmdLineArgs2,Components.CmdLineArgs] <- 1.0
m[App.CmdLineArgs2,Components.CmdLineArgs2] <- 1.0

m[App.CreateDir,Components.Runtime] <- 1.0
m[App.CreateDir,Components.PrintLine] <- 1.0
m[App.CreateDir,Components.CreateDir] <- 1.0

m[App.CreateDir2,Components.Runtime] <- 1.0
m[App.CreateDir2,Components.PrintLine] <- 1.0
m[App.CreateDir2,Components.CreateDir2] <- 1.0

m[App.WriteFile,Components.Runtime] <- 1.0
m[App.WriteFile,Components.PrintLine] <- 1.0
m[App.WriteFile,Components.WriteFile] <- 1.0

m[App.RandInt,Components.Runtime] <- 1.0
m[App.RandInt,Components.PrintLine] <- 1.0
m[App.RandInt,Components.RandInt] <- 1.0

m[App.RegexMatch,Components.Runtime] <- 1.0
m[App.RegexMatch,Components.PrintLine] <- 1.0
m[App.RegexMatch,Components.RegexMatch] <- 1.0

m[App.TcpSimple,Components.Runtime] <- 1.0
m[App.TcpSimple,Components.PrintLine] <- 1.0
m[App.TcpSimple,Components.TcpSimple] <- 1.0

m[App.CsvWrite,Components.Runtime] <- 1.0
m[App.CsvWrite,Components.PrintLine] <- 1.0
m[App.CsvWrite,Components.CsvWrite] <- 1.0

m[App.ParametersObjectBaseline,Components.Runtime] <- 1.0
m[App.ParametersObjectBaseline,Components.PrintLine] <- 1.0
m[App.ParametersObjectBaseline,Components.ParametersObjectBaseline] <- 1.0

m[App.ParametersObject,Components.Runtime] <- 1.0
m[App.ParametersObject,Components.PrintLine] <- 1.0
m[App.ParametersObject,Components.ParametersObjectBaseline] <- 1.0
m[App.ParametersObject,Components.ParametersObject] <- 1.0

m[App.JsonWrite,Components.Runtime] <- 1.0
m[App.JsonWrite,Components.PrintLine] <- 1.0
m[App.JsonWrite,Components.JsonWrite] <- 1.0

// C values
let cParams = vector [
    10752.; // Baseline
    11776.; // SumStrings
    10752.; // ParseFloat
    10752.; // StrReverse
    11264.; // ToLower
    11264.; // StrEmpty
    10752.; // ArrayInit
    10752.; // CmdLineArgs
    11264.; // ReadFile
    201216.; // ZipFile
    10752.; // CreateFile
    12288.; // Win32Window
    12288.; // Win32Button
    10752.; // PrintLine
    11264.; // ProxyCallBaseline
    11264.; // ProxyCall
    15360.; // CmdLineArgs2
    10752.; // CreateDir
    12288.; // CreateDir2
    10752.; // WriteFile
    10752.; // RandInt
    322560.; // RegexMatch
    12288.; // TcpSimple
    12800.; // CsvWrite
    11776.; // ParametersObjectBaseline
    11776.; // ParametersObject
    17920.; // JsonWrite
]

// Rust values
let rustParams = vector [
    125440.; // Baseline
    138752.; // SumStrings
    155648.; // ParseFloat
    139264.; // StrReverse
    155648.; // ToLower
    138240.; // StrEmpty
    138752.; // ArrayInit
    145408.; // CmdLineArgs
    151552.; // ReadFile
    1074176.; // ZipFile
    146432.; // CreateFile
    134656.; // Win32Window
    135168.; // Win32Button
    138240.; // PrintLine
    139264.; // ProxyCallBaseline
    139264.; // ProxyCall
    685568.; // CmdLineArgs2
    155136.; // CreateDir
    155136.; // CreateDir2
    150528.; // WriteFile
    151552.; // RandInt
    1764864.; // RegexMatch
    175104.; // TcpSimple
    187392.; // CsvWrite
    164864.; // ParametersObjectBaseline
    164864.; // ParametersObject
    149504.; // JsonWrite
]

// Naot values
let naotParams = vector [
    1044480.; // Baseline
    1105920.; // SumStrings
    1131520.; // ParseFloat
    1119744.; // StrReverse
    1107968.; // ToLower
    1105408.; // StrEmpty
    1108992.; // ArrayInit
    1105920.; // CmdLineArgs
    1228288.; // ReadFile
    2117632.; // ZipFile
    1210368.; // CreateFile
    1157632.; // Win32Window
    1158656.; // Win32Button
    1105408.; // PrintLine
    1106944.; // ProxyCallBaseline
    1044480.; // ProxyCall
    3415040.; // CmdLineArgs2
    1119232.; // CreateDir
    1119232.; // CreateDir2
    1211904.; // WriteFile
    1105408.; // RandInt
    1542656.; // RegexMatch
    1219584.; // TcpSimple
    1219072.; // CsvWrite
    1125888.; // ParametersObjectBaseline
    1126400.; // ParametersObject
    1990144.; // JsonWrite
]

// Go values
let goParams = vector [
    863744.; // Baseline
    1270272.; // SumStrings
    1288704.; // ParseFloat
    1272832.; // StrReverse
    1283584.; // ToLower
    1269760.; // StrEmpty
    1270784.; // ArrayInit
    1270272.; // CmdLineArgs
    1377792.; // ReadFile
    1610240.; // ZipFile
    1278464.; // CreateFile
    1304064.; // Win32Window
    1305088.; // Win32Button
    1270272.; // PrintLine
    1274368.; // ProxyCallBaseline
    1275392.; // ProxyCall
    1372160.; // CmdLineArgs2
    1274368.; // CreateDir
    1377280.; // CreateDir2
    1277952.; // WriteFile
    1354752.; // RandInt
    1544192.; // RegexMatch
    1930752.; // TcpSimple
    1295872.; // CsvWrite
    1292288.; // ParametersObjectBaseline
    1292800.; // ParametersObject
    1491968.; // JsonWrite
]

Vector<float>.Build.Dense(6 (*components*))

let components = [
    ("Runtime", Components.Runtime)
    ("PrintLine", Components.PrintLine)
    ("SumStrings", Components.SumStrings)
    ("ParseFloat", Components.ParseFloat)
    ("StrReverse", Components.StrReverse)
    ("ToLower", Components.ToLower)
    ("StrEmpty", Components.StrEmpty)
    ("ArrayInit", Components.ArrayInit)
    ("CmdLineArgs", Components.CmdLineArgs)
    ("CmdLineArgs2", Components.CmdLineArgs2)
    ("ReadFile", Components.ReadFile)
    ("WriteFile", Components.WriteFile)
    ("CreateFile", Components.CreateFile)
    ("CreateDir", Components.CreateDir)
    ("CreateDir2", Components.CreateDir2)
    ("ZipFile", Components.ZipFile)
    ("Win32Window", Components.Win32Window)
    ("Win32Button", Components.Win32Button)
    ("ProxyCallBaseline", Components.ProxyCallBaseline)
    ("ProxyCall", Components.ProxyCall)
    ("RandInt", Components.RandInt)
    ("RegexMatch", Components.RegexMatch)
    ("TcpSimple", Components.TcpSimple)
    ("CsvWrite", Components.CsvWrite)
    ("ParametersObjectBaseline", Components.ParametersObjectBaseline)
    ("ParametersObject", Components.ParametersObject)
    ("JsonWrite", Components.JsonWrite)
]

let cComponents = m.Solve(cParams)
let rustComponents = m.Solve(rustParams)
let naotComponents = m.Solve(naotParams)
let goComponents = m.Solve(goParams)
let printComponents header (cComponents: Vector<float>) =
    printfn ""
    printfn "## %s" header
    printfn ""
    printfn "| Component    | Size (B) |"
    printfn "| ------------ | -----: |"
    for (name, comp) in components do
        printfn "| %-11s| %s |" name (cComponents[comp].ToString("N0"))


let printTable (cComponents: (string * Vector<float>) seq) =
    printfn "## Cross language comparison table"
    printfn ""
    printf "| Component    | "
    for (lang, _) in cComponents do
        printf "%s - Size (B) |" lang
    printfn ""
    printf "| ------------    | "
    for (_, _) in cComponents do
        printf "-----: |"
    printfn ""

    for (name, code) in components do
        printf "| %-20s |" name
        for (_, items) in cComponents do
            printf "%9s |" (items[code].ToString("N0"))
        printfn ""

printTable [("C", cComponents); ("Rust", rustComponents); ("C#", naotComponents); ("Go", goComponents)]
printfn ""
printComponents "C language basics" cComponents
printComponents "Rust language basics" rustComponents
printComponents "C# NativeAOT language basics" naotComponents
printComponents "Go language basics" goComponents