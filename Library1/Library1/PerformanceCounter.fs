#if INTERACTIVE
#else
module PerformanceCounter
#endif

open System
open System.IO
open System.Diagnostics

let wordCount() = 
    //get the "Private Bytes" performance counter
    let proc = Process.GetCurrentProcess()
    let counter = new PerformanceCounter("Process", "Private Bytes", proc.ProcessName)

    //read the file
    let lines = File.ReadAllLines(@"/Applications/XAMPP/xamppfiles/htdocs/f#-tuts/Library1/Library1/sample.txt")
    //do a very naive unique-word count (to prove we get the same results
    //whichever way we access teh file)
    let wordCount = lines |> Seq.map (fun line -> line.Split([|' '|])) |> Seq.concat |> Seq.distinct |> Seq.length
    printfn "Private bytes: %f" (counter.NextValue())
    printfn "Word count: %i" wordCount

[<EntryPoint>]
let main argv = 
  wordCount()
  Console.ReadKey() |> ignore
  0

