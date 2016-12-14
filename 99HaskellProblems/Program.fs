// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open Lists.OneToTen
open Microsoft.FSharp.Core
open System

[<EntryPoint>]
let main argv = 
    printfn "%A" (isPalindrome' [1; 2; 3; 5; 3; 2; 1])
    Console.ReadKey() |> ignore
    0 // return an integer exit code
