namespace dotnet_drama

open System
open System.Security.Cryptography
open System.Text

/// <summary> Initial module </summary>
module Main =
    [<EntryPoint>]
    let main (argv) =
        let daysSinceDrama = 0
        printfn $"It's been {daysSinceDrama} days since .NET had drama."
        0
