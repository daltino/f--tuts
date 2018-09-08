#if INTERACTIVE
#else
module Points
#endif

////A point type
//type point = { Top:int; Left: int } with
//    //the swap member creates a new point with the left/top coords reversed
//    member x.Swap() = { Top = x.Left; Left = x.Top }

////create a new point
//let myPoint = { Top = 3; Left = 7}

////print the initial point
//printfn "%A" myPoint
////create a new point with the coords swapped
//let nextPoint = myPoint.Swap()
////print the new point
//printfn "%A" nextPoint

// a type representing the amount of a specific drink
type DrinkAmount =
     | Coffee of int
     | Tea of int
     | Water of int
     with
        // get a string representation of the value
        override x.ToString() =
           match x with
           | Coffee x -> Printf.sprintf "Coffee: %i" x
           | Tea x -> Printf.sprintf "Tea: %i" x
           | Water x -> Printf.sprintf "Water: %i" x
// create a new instance of DrinkAmount
let t = Tea 2
// print out the string
printfn "%s" (t.ToString())