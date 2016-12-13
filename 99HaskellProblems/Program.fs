// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open Lists.OneToTen
open Microsoft.FSharp.Core
open System

[<EntryPoint>]
let main argv = 
    printfn "%A" (reverse [0 .. 2 .. 55])
    Console.ReadKey() |> ignore
    0 // return an integer exit code
