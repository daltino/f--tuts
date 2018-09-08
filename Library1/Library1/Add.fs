#if INTERACTIVE
#else
module Add
#endif

let n = 10

let add a b = a + b
let result = add n 4

printfn "result = %i" result

// function to calculate a midpoint
let halfWay a b =
    let dif = b - a
    let mid = dif / 2
    mid + a

// call the function and print the results
printfn "(halfway 5 11) = %i" (halfWay 5 11)
printfn "(halfway 11 5) = %i" (halfWay 11 5)

let result2 = 
    add (add 4 5) (add 6 7)

let (|>) x f = f x
let result3 =
    add 6 7 |> add 4 |> add 5