#if INTERACTIVE
#else
module Programs
#endif

//let printMessages() = 
//    // define message and print it
//    let message = "Important"
//    printfn "%s" message;
//    // define an inner function that redefines value of message
//    let innerFun () =
//        let message = "Very Important"
//        printfn "%s" message
//    // call the inner function
//    innerFun()
//    // finally print the first message again
//    printfn "%s" message

//printMessages()

//// a function to generate the Fibonacci numbers
//let rec fib x =
//    match x with
//    | 1 -> 1
//    | 2 -> 1
//    | x -> fib (x - 1) + fib (x - 2)

//// call the function and print the results
//printfn "(fib 2) = %i" (fib 2)
//printfn "(fib 6) = %i" (fib 6)
//printfn "(fib 11) = %i" (fib 11)

//let (+*) a b = (a + b) * a * b
//printfn "(1 +* 2) = %i" (1 +* 2)

//let (|>) x f = f x
//let result = 0.5 |> System.Math.Cos

//// definition of Lucas numbers using pattern matching
//let rec luc x =
//    match x with
//    | x when x <= 0 -> failwith "value must be greater than 0"
//    | 1 -> 1
//    | 2 -> 3
//    | x -> luc (x - 1) + luc (x - 2)

//// call the function and print the results
//printfn "(luc 2) = %i" (luc 2)
//printfn "(luc 6) = %i" (luc 6)
//printfn "(luc 11) = %i" (luc 11)
//printfn "(luc 12) = %i" (luc 12)

//// concatenate a list of strings into single strings
//let rec concatStringList = 
//    function head :: tail -> head + concatStringList tail | [] -> ""

//// test data
//let jabber = ["'Twas "; "brillig, "; "the "; "slithy "; "toves "; "..."]
//// call the function
//let completJabber = concatStringList jabber
//// print the result
//printfn "%s" completJabber

//let resultcf = 
//    if System.DateTime.Now.Second % 2 = 0 then
//        "heads"
//    else
//        "tails"

//printfn "%A" resultcf

//let resultcfb =
//    match System.DateTime.Now.Second % 2 = 0 with
//    | true -> "heads"
//    | false -> "false"

//let resulto = 
//    if System.DateTime.Now.Second % 2 = 0 then
//        box "heads"
//    else
//        box false

//printfn "%A" resulto

//let emptyList = []
//let oneItem = "one " :: []
//let twoItem = "one " :: "two " :: []
//let twoLists = ["one, "; "two, "] @ ["buckle "; "my "; "shoe "]

//// list of objects
//let objList = [box 1; box 2.0; box "three"]
//// print the lists
//let main() =
//    printfn "%A" emptyList
//    printfn "%A" oneItem
//    printfn "%A" twoItem
//    printfn "%A" twoLists
//    printfn "%A" objList

//// call the main function
//main()

//// create a list of one item
//let one = ["one "]
//// create a list of two items
//let two = "two " :: one
//// create a list of three items
//let three = "three " :: two

//// reverse the list of three items
//let rightWayRound = List.rev three

//printfn "%A" three
//printfn "%A" rightWayRound

//// list to be concatenated
//let listOfList = [[2; 3; 5]; [7; 11; 13]; [17; 19; 23; 29]]

//// definition of a concatenation function
//let rec concatList l =
//    match l with
//    | head :: tail -> head @ (concatList tail)
//    | [] -> []

//// call the function
//let primes = concatList listOfList
//// print the results
//printfn "%A" primes

//// function that attempts to find various sequences
//let rec findSequence l =
//    match l with
//    // match a list containing exactly 3 numbers
//    | [x; y; z] -> printfn "Last 3 numbers in the list were %i %i %i" x y z
//    // match a list of 1, 2, 3 in a row
//    | 1 :: 2 :: 3 :: tail -> 
//        printfn "Found sequence 1, 2, 3 within the list" 
//        findSequence tail
//    // if neither case matches and items remain
//    // recursively call the function
//    | head :: tail -> findSequence tail
//    // if no items remain terminate
//    | [] -> ()

//// some test data
//let testSequence = [1; 2; 3; 4; 5; 6; 7; 8; 9; 8; 7; 6; 5; 4; 3; 2; 1]
//// call the function
//findSequence testSequence

//let rec addOneAll list =
//    match list with
//    | head :: rest -> head + 1 :: addOneAll rest
//    | [] -> []

//printfn "(addOneAll [1; 2; 3]) = %A" (addOneAll [1; 2; 3])

////let rec map func list =
////    match list with
////    | head :: rest -> func head :: map func rest
////    | [] -> []

//let result = List.map ((+) 1) [1;2;3]

//printfn "List.map ((+) 1) [1;2;3] = %A" result

//// create some list comprehensions
//let numericList = [0 .. 9]
//let alpherSeq = seq{'A' .. 'Z'}

//// print them
//printfn "%A" numericList
//printfn "%A" alpherSeq

//// create some list comprehensions
//let multiplesOfThree = [ 0 .. 3 .. 30 ]
//let revNumericSeq = [ 9 .. -1 .. 0 ]
//// print them
//printfn "%A" multiplesOfThree
//printfn "%A" revNumericSeq

//// a sequence of squares
//let squares = seq{ for x in 1 .. 10 -> x*x }

//// print the sequence
//printfn "%A" squares

//// a sequence of even numbers
//let evens n = seq{ for x in 1 .. n do if x % 2 = 0 then yield x }

//// print the sequence
//printfn "%A" (evens 10)

//// sequence of tuples representing points
//let squarePoints n = seq{ for x in 1 .. n do for y in 1 .. n do yield x, y }

//// print the sequence
//printfn "%A" (squarePoints 3)

//let doNothingToAnInt (x: int) = x
//let intList = [1;2;3]

//let (stringList: list<string>) = ["one";"two";"three"]

//let pair = true, false
//let b1, b2 = pair
//let b3, _ = pair
//let _, b4 = pair

//type Name = string
//type Fullname = string * string
//let fullNameToSting (x: Fullname) =
//    let first, second = x in
//    first + " " + second

////define an organization with unique fields
//type Organization1 = {boss:string; lackeys:string list}
////create an instance of this organization
//let rainbow = {boss = "Jeffrey"; lackeys = ["Zippy";"George";"Bungle"]}

////define two organizations with overlapping fields
//type Organization2 = {chief: string; underlings: string list}
//type Organization3 = {chief: string; indians: string list}

////create an instance of Organization2
//let (thePlayers: Organization2) = {chief = "Peter Quince"; underlings = ["Francis Flute";"Robin Starveling";"Tom Snout";"Snug";"Nick Bottom"]}
////create an instance of Organization3
//let (wayneManor: Organization3) = {chief = "Batman"; indians = ["Robin";"Alfred";]}

////access a field from this type
//printfn "wayneManor.chief = %s" wayneManor.chief

////create a modified instance of this type
//let wayneManor' = {wayneManor with indians = ["Alfred"]}

////print out the two organizations
//printfn "wayneManor - %A" wayneManor
//printfn "wayneManor' - %A" wayneManor'

//type representing a couple
//type Couple = {him:string; her:string}

////list of couples
//let couples = 
//    [{him="Brad";her="Angelina"};
//    {him="Becks";her="Posh"};
//    {him="Chris";her="Gwyneth"};
//    {him="Michael";her="Catherine"};]

////function to find "David" from a list of couples
//let rec findDavid l = match l with
//                      | {him=x;her="Posh"} :: tail -> x
//                      | _ :: tail -> findDavid tail
//                      | [] -> failwith "Couldn't find David"

////print the results
//printfn "%A" (findDavid couples)

//type Volume = | Liter of float | UsPint of float | ImperialPint of float

////various kinds of volumes
//let vol1 = Liter 2.5
//let vol2 = UsPint 2.5
//let vol3 = ImperialPint (2.5)

////union type using field labels
//type Shape = | Square of side:float | Rectangle of width:float * height:float | Circle of radius:float
////create an instance of a union type without using the field label
//let sq = Square 1.2
////create an instance of a union type using the field label
//let sq2 = Square(side=1.2)
////create an instance of a union type using multiple field labels
//let rect3 = Rectangle(height=3.4, width=1.2)

////some functions to convert between volumes
//let convertVolumeToLiter x = match x with
//                             | Liter x -> x
//                             | UsPint x -> x * 0.473
//                             | ImperialPint x -> x * 0.568
//let convertVolumeUsPint x = match x with
//                            | Liter x -> x * 2.113
//                            | UsPint x -> x
//                            | ImperialPint x -> x * 1.201
//let convertVolumeImperialPint x = match x with
//                                  | Liter x -> x * 1.760
//                                  | UsPint x -> x * 0.833
//                                  | ImperialPint x -> x

////a function to print a volume
//let printVolumes x = printfn "Volume in liters = %f, in us pints = %f, in imperial pints = %f" (convertVolumeToLiter x) (convertVolumeUsPint x) (convertVolumeImperialPint x)

////print the results
//printVolumes vol1
//printVolumes vol2
//printVolumes vol3

//// definition of a binary tree
//type 'a BinaryTree =
//    | BinaryNode of 'a BinaryTree * 'a BinaryTree
//    | BinaryValue of 'a
//// create an instance of a binary tree
//let tree1 =
//    BinaryNode(
//        BinaryNode ( BinaryValue 1, BinaryValue 2),
//        BinaryNode ( BinaryValue 3, BinaryValue 4) )
//// definition of a tree
//type Tree<'a> =
//    | Node of Tree<'a> list
//    | Value of 'a
//// create an instance of a tree
//let tree2 =
//    Node( [ Node( [Value "one"; Value "two"] ) ;
//        Node( [Value "three"; Value "four"] ) ] )
//// function to print the binary tree
//let rec printBinaryTreeValues x =
//    match x with
//    | BinaryNode (node1, node2) ->
//        printBinaryTreeValues node1
//        printBinaryTreeValues node2
//    | BinaryValue x ->
//        printf "%A, " x
//// function to print the tree
//let rec printTreeValues x =
//    match x with
//    | Node l -> List.iter printTreeValues l
//    | Value x ->
//        printf "%A, " x
//// print the results
//printBinaryTreeValues tree1
//printfn ""
//printTreeValues tree2

////represents an XML attribute
//type XmlAttribute = {AttribName: string; AttribValue: string;}
//represents an XML element
//type XmlElement = {ElementName:string; Attributes: list<XmlAttribute>; InnerXml:XmlTree}
////represents an XML tree
//and XmlTree = | Element of XmlElement | ElementList of list<XmlTree> | Text of string

//open System
//// definition of the active pattern
//let (|Bool|Int|Float|String|) input =
//    // attempt to parse a bool
//    let success, res = Boolean.TryParse input
//    if success then Bool(res)
//    else
//        // attempt to parse an int
//        let success, res = Int32.TryParse input
//        if success then Int(res)
//        else
//            // attempt to parse a float (Double)
//            let success, res = Double.TryParse input
//            if success then Float(res)
//            else String(input)
//// function to print the results by pattern
//// matching over the active pattern
//let printInputWithType input =
//    match input with
//    | Bool b -> printfn "Boolean: %b" b
//    | Int i -> printfn "Integer: %i" i
//    | Float f -> printfn "Floating point: %f" f
//    | String s -> printfn "String: %s" s

//// print the results
//printInputWithType "true"
//printInputWithType "12"
//printInputWithType "-12.1"

//open System.Text.RegularExpressions

////the definition of the active pattern
//let (|Regex|_|) regexPattern input = 
//    //create and attempt to match a regular expression
//    let regex = new Regex(regexPattern)
//    let regexMatch = regex.Match(input)
//    //return either Some or None
//    if regexMatch.Success then
//        Some regexMatch.Value
//    else
//        None

////function to print the results by pattern
////matching over different instances of the
////active pattern
//let printInputWithType input = match input with
//                                    | Regex "$true|false^" s -> printfn "Boolean: %s" s
//                                    | Regex @"$-?\d+^" s -> printfn "Integer: %s" s
//                                    | Regex "$-?\d+\.\d*^" s -> printfn "Floating point: %s" s
//                                    | _ -> printfn "String: %s" input

//// print the results
//printInputWithType "true"
//printInputWithType "12"
//printInputWithType "-12.1"

//[<Measure>]type liter
//[<Measure>]type pint

//let vol1 = 2.5<liter>
//let vol2 = 2.5<pint>

////let newVol = vol1 + vol2
//let ratio = 1.0<liter> / 1.76056338<pint>

////a function to convert pints to liters
//let convertPintToLiter pints = pints * ratio
////perform the conversion and add the values
//let newVol = vol1 + (convertPintToLiter vol2)
////stripping off unit of measure (<= F# 3.1)
//printfn "The volume is %f" (float vol1)
////using a format placeholder with a unit-of-measure value (>= F# 4.0)
//printfn "The volume is %f" vol1

////define an exception type
//exception WrongSecond of int

////list of prime numbers
//let primes = [2;3;5;7;11;13;17;19;23;29;31;37;41;43;47;53;59]
////function to test if current second is prime
//let testSecond() = try
//                       let currentSecond = System.DateTime.Now.Second in
//                       //test if current second is in the list primes
//                       if List.exists (fun x -> x = currentSecond) primes then
//                           //use the failwith function to raise an exception
//                           failwith "A primes second"
//                       else
//                           //raise the WrongSecond exception
//                           raise (WrongSecond currentSecond)
//                    with
//                    //catch the wrong second exception
//                    WrongSecond x -> printfn "The current was %i, which is not prime" x

////call the function
//testSecond()

////function to write to a file
//let writeToFile() = 
//    //open a file
//    let file = System.IO.File.CreateText("/Applications/XAMPP/xamppfiles/htdocs/f#-tuts/Library1/Library1/test.txt")
//    try
//        //write to it
//        file.WriteLine("Hello F# users")
//    finally
//        //close the file, this will happen even if
//        //an exception occurs writing to the file
//        file.Dispose()

////call the function
//writeToFile()

//let lazyValue = lazy ( 2 + 2 )
//let actualValue = Lazy.force lazyValue
//printfn "%i" actualValue

//let lazySideEffect =
//    lazy
//        ( let temp = 2 + 2
//          printfn "%i" temp
//          temp )
//printfn "Force value the first time: "
//let actualValue1 = lazySideEffect.Force()
//printfn "Force value the second time: "
//let actualValue2 = lazySideEffect.Force()

//// the lazy list definition
//let lazyList =
//        Seq.unfold
//            (fun x ->
//                if x < 13 then
//                    // if smaller than the limit return
//                    // the current and next value
//                    Some(x, x + 1)
//                else
//                    // if great than the limit
//                    // terminate the sequence
//                    None)
//            10
//// print the results
//printfn "%A" lazyList

//create an infinite list of Fibonacci numbers
let fibs = Seq.unfold
                (fun (n0, n1) -> Some(n0, (n1, n0 + n1)))
                (1I,1I)
//take the first twenty items from the list
let first20 = Seq.take 20 fibs
//print the finite list
printfn "%A" first20