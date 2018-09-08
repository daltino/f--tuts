#if INTERACTIVE
#else
module FindAndFilter
#endif

//let shortWordList = [|"hat"; "hot"; "bat"; "lot"; "mat"; "dot"; "rat";|]

//let atWords = shortWordList |> Seq.filter (fun x -> x.EndsWith("at"))

//let otWord = shortWordList |> Seq.find (fun x -> x.EndsWith("ot"))

//let ttWord = shortWordList |> Seq.tryFind (fun x -> x.EndsWith("tt"))

//atWords |> Seq.iter (fun x -> printf "%s ... " x)
//printfn ""
//printfn "%s" otWord
//printfn "%s" (match ttWord with | Some x -> x | None -> "Not found")

let tenOnes = Seq.init 10 (fun _ -> 1)
let allIntegers = Seq.initInfinite(fun x -> System.Int32.MinValue + x)
let firstTenInts = Seq.take 10 allIntegers

tenOnes |> Seq.iter (fun x -> printf "%i ... " x)
printfn ""
printfn "%A" firstTenInts