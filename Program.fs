// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    printfn "%s" (typeof<System.Net.Mail.MailAddress>.AssemblyQualifiedName)
    0 // return an integer exit code
