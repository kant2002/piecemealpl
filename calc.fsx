#r "nuget: MathNet.Numerics, 5.0.0"
#r "nuget: MathNet.Numerics.FSharp, 5.0.0"

open System

open MathNet.Numerics
// The DenseMatrix and LUDecomposition classes reside in the 
// Numerics.NET.LinearAlgebra namespace.
open MathNet.Numerics.LinearAlgebra

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
    let PrintLine = 1
    [<Literal>]
    let SumStrings = 2
    [<Literal>]
    let ParseFloat = 3
    [<Literal>]
    let StrReverse = 4
    [<Literal>]
    let ToLower = 5
    [<Literal>]
    let StrEmpty = 6
    [<Literal>]
    let ArrayInit = 7
    [<Literal>]
    let CmdLineArgs = 8
    [<Literal>]
    let CmdLineArgs2 = 9
    [<Literal>]
    let ReadFile = 10
    [<Literal>]
    let WriteFile = 11
    [<Literal>]
    let CreateFile = 12
    [<Literal>]
    let CreateDir = 13
    [<Literal>]
    let CreateDir2 = 14
    [<Literal>]
    let ZipFile = 15
    [<Literal>]
    let Win32Window = 16
    [<Literal>]
    let Win32Button = 17
    [<Literal>]
    let ProxyCallBaseline = 18
    [<Literal>]
    let ProxyCall = 19
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
    [<Literal>]
    let DeleteFile = 27
    [<Literal>]
    let ExistsFile = 28

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
    [<Literal>]
    let DeleteFile = 27
    [<Literal>]
    let ExistsFile = 28

let m = Matrix<float>.Build.Dense(29 (*apps*), 29 (*components*))
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

m[App.DeleteFile,Components.Runtime] <- 1.0
m[App.DeleteFile,Components.PrintLine] <- 1.0
m[App.DeleteFile,Components.DeleteFile] <- 1.0

m[App.DeleteFile,Components.Runtime] <- 1.0
m[App.DeleteFile,Components.PrintLine] <- 1.0
m[App.ExistsFile,Components.ExistsFile] <- 1.0

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

// Load measured binary sizes from the most recent results_*.csv file.
// The row order in the CSV matches the App enum order used below.
open System.IO
open System.Globalization

let private rows =
    let latest =
        Directory.GetFiles(__SOURCE_DIRECTORY__, "results_*.csv")
        |> Array.sort
        |> Array.last
    File.ReadAllLines(latest)
    |> Array.skip 1
    |> Array.filter (fun line -> line.Trim() <> "")
    |> Array.map (fun line ->
        let cols = line.Split(',') |> Array.map (fun s -> s.Trim('"'))
        let value i = Double.Parse(cols.[i], CultureInfo.InvariantCulture)
        (value 1, value 2, value 3, value 4))

let private paramVector selector =
    rows |> Array.map selector |> vector

// C values
let cParams = paramVector (fun (c, _, _, _) -> c)

// Rust values
let rustParams = paramVector (fun (_, r, _, _) -> r)

// Naot values
let naotParams = paramVector (fun (_, _, n, _) -> n)

// Go values
let goParams = paramVector (fun (_, _, _, g) -> g)

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
    ("DeleteFile", Components.DeleteFile)
    ("ExistsFile", Components.ExistsFile)
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
    printfn "| Component                | Size (B)  |"
    printfn "| ------------------------ | --------: |"
    for (name, comp) in components do
        printfn "| %-25s| %9s |" name (cComponents[comp].ToString("N0", CultureInfo.InvariantCulture))


let printTable (cComponents: (string * Vector<float>) seq) =
    printfn "## Cross language comparison table"
    printfn ""
    printf "| Component                 | "
    for (lang, _) in cComponents do
        printf "%s - Size (B) |" lang
    printfn ""
    printf "| ----------------------    | "
    for (_, _) in cComponents do
        printf "-------: |"
    printfn ""

    for (name, code) in components do
        printf "| %-25s |" name
        for (_, items) in cComponents do
            printf "%9s |" (items[code].ToString("N0", CultureInfo.InvariantCulture))
        printfn ""

printTable [("C", cComponents); ("Rust", rustComponents); ("C#", naotComponents); ("Go", goComponents)]
printfn ""
printComponents "C language basics" cComponents
printComponents "Rust language basics" rustComponents
printComponents "C# NativeAOT language basics" naotComponents
printComponents "Go language basics" goComponents
