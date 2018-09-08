#if INTERACTIVE
#else
module Prog4
#endif

//let aFunction() = ()
//let () = aFunction ()
////--or--
//do aFunction()
////--or--
//aFunction()

//let poem() = 
//    printfn "I wandered lonely as a cloud"
//    printfn "That floats on high o'er vales and hills,"
//    printfn "When all at once I saw a crowd,"
//    printfn "A host, of golden daffodils"

//poem()

//let getShorty() = "shorty"
//let _= getShorty()
////--or--
//ignore(getShorty())
////--or--
//getShorty() |> ignore

////a mutable identifier
//let mutable phrase = "How can I be sure, "

////print the phrase
//printfn "%s" phrase
////update the phrase
//phrase <- "In a world that's constantly changing"
////reprint the phrase
//printfn "%s" phrase

//let mutable number = "one"
//number <- 1

////demonstration of redefining X
//let redefineX() = 
//    let x = "One"
//    printfn "Redifining:\r\nx = %s" x
//    if true then
//        let x = "Two"
//        printfn "x = %s" x
//    printfn "x = %s" x

////demonstration of mutating X
//let mutableX() = 
//    let mutable x = "One"
//    printfn "Mutating:\r\nx = %s" x
//    if true then
//        x <- "Two"
//        printfn "x = %s" x
//    printfn "x = %s" x

////run the demos
//redefineX()
//mutableX()

//let mutableY() =
//    let mutable y = "One"
//    printfn "Mutating:\r\nx = %s" y
//    let f() =
//        // this causes an error as
//        // mutables can't be captured
//        y <- "Two"
//        printfn "x = %s" y
//    f()
//    printfn "x = %s" y

//mutableY()

////a record with a mutable field
//type Couple = {Her: string; mutable Him: string}

////a create an instance of the record
//let theCouple = {Her = "Elizabeth Taylor"; Him = "Nicky Hilton"}

////function to change the contents of the record over time
//let changeCouple() = 
//    printf "%A" theCouple
//    theCouple.Him <- "Michael Wilding"
//    printfn "%A" theCouple
//    theCouple.Him <- "Michael Todd"
//    printfn "%A" theCouple
//    theCouple.Him <- "Eddie Fisher"
//    printfn "%A" theCouple
//    theCouple.Him <- "Richard Burton"
//    printfn "%A" theCouple
//    theCouple.Him <- "John Warner"
//    printfn "%A" theCouple
//    theCouple.Him <- "Larry Fortensky"
//    printfn "%A" theCouple

////call the function
//changeCouple()

//theCouple.Her <- "Sybil Williams"
//printfn "%A" theCouple

//let totalArray() = 
//    //define an array literal
//    let array = [|1;2;3|]
//    //define a counter
//    let total = ref 0
//    //loop over the array
//    for x in array do
//        //keep a running total
//        total := !total + x
//    //print the total
//    printfn "total: %i" !total

//totalArray()

////capture the inc, dec, and show functions
//let inc, dec, show = 
//    //define the shared state
//    let n = ref 0
//    //a function to increment
//    let inc () = 
//        n := !n + 1
//    //a function to decrement
//    let dec () =
//        n := !n - 1
//    //a function to show the current state
//    let show() = 
//        printfn "%i" !n
    
//    //return the functions to the top level
//    inc, dec, show

////test the functions
//inc()
//inc()
//dec()
//show()

////this will work from F# 4.0
//let inc, dec, show = 
//    //define the shared state
//    let mutable n = 0
//    //a function to increment
//    let inc() = 
//        n <- n + 1
//    //a function to decrement
//    let dec () = 
//        n <- n - 1
//    //a function to show the current state
//    let show() = 
//        printfn "%i" n

//    //return the functions to top level
//    inc, dec, show

////test the functions
//inc()
//inc()
//dec()
//show()

////define an array literal
//let rhymeArray = [| "Went to market";"Stayed to home";"Had roast beef";"Had none" |]

////unpack the array into identifiers
//let firstPiggy = rhymeArray.[0]
//let secondPiggy = rhymeArray.[1]
//let thirdPiggy = rhymeArray.[2]
//let fourthPiggy = rhymeArray.[3]

////update elements of the array
//rhymeArray.[0] <- "Wee,"
//rhymeArray.[1] <- "Wee,"
//rhymeArray.[2] <- "Wee,"
//rhymeArray.[3] <- "all they way home"

////give a short name to the new line characters
//let nl = System.Environment.NewLine

////print out the identifiers & array
//printfn "%s%s%s%s%s%s%s%s"
//    firstPiggy nl
//    secondPiggy nl
//    thirdPiggy nl
//    fourthPiggy nl
//printfn "%A" rhymeArray

////define a jagged array literal
//let jagged = [| [| "one" |]; [| "two"; "three" |]|]
////unpack elements from the arrays
//let singleDim = jagged.[0]
//let itemOne = singleDim.[0]
//let itemTwo = jagged.[1].[0]
////print some of the unpacked elements
//printfn "%s %s" itemOne itemTwo

////create a square array
////initially populated with zeros
//let square = Array2D.create 2 2 0

////populate the array
//square.[0,0] <- 1
//square.[0,1] <- 2
//square.[1,0] <- 3
//square.[1,1] <- 4

////print the array
//printf "%A" square

//define Pascal's Triangle as an
//array literal
//let pascalsTriangle =
//    [| [|1|];
//       [|1; 1|];
//       [|1; 2; 1|];
//       [|1; 3; 3; 1|];
//       [|1; 4; 6; 4; 1|];
//       [|1; 5; 10; 10; 5; 1|];
//       [|1; 6; 15; 20; 15; 6; 1|];
//       [|1; 7; 21; 35; 35; 21; 7; 1|];
//       [|1; 8; 28; 56; 70; 56; 28; 8; 1|]; |]

////collect elements from the jagged array
////assing them to a square array
//let numbers = 
//    let length = (Array.length pascalsTriangle) in
//    let temp = Array2D.create 3 length 0 in
//    for index = 0 to length - 1 do
//        let natureIndex = index - 1 in
//        if natureIndex >= 0 then
//            temp.[0, index] <- pascalsTriangle.[index].[natureIndex]
//        let triangularIndex = index - 2 in
//        if triangularIndex >= 0 then
//            temp.[1, index] <- pascalsTriangle.[index].[triangularIndex]
//        let tetrahedralIndex = index - 3 in
//        if tetrahedralIndex >= 0 then
//            temp.[2, index] <- pascalsTriangle.[index].[tetrahedralIndex]
//    done
//    temp

////print the array
//printfn "%A" numbers

////an array of characters
//let chars = [| '1' .. '9' |]

////an array of tuples of number, square
//let squares = [| for x in 1 .. 9 -> x, x*x |]

////print out both arrays
//printfn "%A" chars
//printfn "%A" squares

//let arr = [|1; 3; 5; 7; 11; 13|]
//let middle = arr.[1..4] // [|3; 5; 7; 11|]
//let start = arr.[..3] // [|1; 3; 5; 7|]
//let tail = arr.[1..] // [|3; 5; 7; 11; 13|]

//let ocean = Array2D.create 100 100 0
//// Create a ship:
//for i in 3..6 do
//    ocean.[i, 5] <- 1
//// Pull out an area hit by a 'shell':
//let hitArea = ocean.[2..5, 2..5]

//// We can see a rectangular area by 'radar':
//let radarArea = ocean.[3..4, *]

//if System.DateTime.Now.DayOfWeek = System.DayOfWeek.Sunday then
//    printfn "Sunday Playlist: Lazy On A Sunday Afternoon - Queen"

//if System.DateTime.Now.DayOfWeek = System.DayOfWeek.Monday then
//    printfn "Monday Playlist: Blue Monday - New Order"
//else
//    printfn "Alt Playlist: Fell In Love With A Girl - White Stripes"

//if System.DateTime.Now.DayOfWeek = System.DayOfWeek.Tuesday then
//    printfn "Tuesday Playlist: Ruby Tuesday - Rolling Stones"
//printfn "Everyday Playlist: Eight Days A Week - Beatles"

//if System.DateTime.Now.DayOfWeek = System.DayOfWeek.Friday then
//    printfn "Friday Playlist: Friday I'm In Love - The Cure"
//    printfn "Friday Playlist: View From The Afternoon - Arctic Monkeys"

////an array for words
//let words = [| "Red"; "Lorry"; "Yellow"; "Lorry" |]

////use a for loop to print each element
//for word in words do
//    printfn "%s" word

////a Ryunosuke Akutagawa haiku array
//let ryunosukeAkutagawa = [| "Green "; "frog,"; "Is"; "your"; "body"; "also"; "freshly"; "painted?" |]

////for loop over the array printing each element
//for index = 0 to Array.length ryunosukeAkutagawa - 1 do
//    printf "%s " ryunosukeAkutagawa.[index]

// a Shuson Kato hiaku array (backwards)
//let shusonKato = [| "watching."; "been"; "have";
//    "children"; "three"; "my"; "realize"; "and";
//    "ant"; "an"; "kill"; "I";
//    |]
//// loop over the array backwards printing each word
//for index = Array.length shusonKato - 1 downto 0 do
//    printf "%s " shusonKato.[index]

//// Count upwards:
//for i in 0..10 do
// printfn "%i green bottles" i
//// Count downwards:
//for i in 10..-1..0 do
// printfn "%i green bottles" i
//// Count upwards in tens
//for i in 0..10..100 do
// printfn "%i green bottles" i

//// a Matsuo Basho hiaku in a mutable list
//let mutable matsuoBasho = [ "An"; "old"; "pond!";
//    "A"; "frog"; "jumps"; "in-";
//    "The"; "sound"; "of"; "water" ]
//while (List.length matsuoBasho > 0) do
//    printf "%s " (List.head matsuoBasho)
//    matsuoBasho <- List.tail matsuoBasho

open System.IO
////test whethere a file "test.txt" exist
//if File.Exists("Applications/XAMPP/xamppfiles/htdocs/f#-tuts/Library1/Library1/test.txt") then
//    printfn "Text file \"test.txt\" is present"
//else
//    printfn "Text file \"test.txt\" does not exist"

////list of files to test
//let files1 = [ "Applications/XAMPP/xamppfiles/htdocs/f#-tuts/Library1/Library1/test1.txt"; 
//               "Applications/XAMPP/xamppfiles/htdocs/f#-tuts/Library1/Library1/test2.txt"; 
//               "Applications/XAMPP/xamppfiles/htdocs/f#-tuts/Library1/Library1/test3.txt" ]

////test if each file exists
//let results1 = List.map File.Exists files1

////print the results
//printfn "%A" results1

////list of files names and desired contents
//let files2 = [ "Applications/XAMPP/xamppfiles/htdocs/f#-tuts/Library1/Library1/test1.bin", [| 0uy |];
//               "Applications/XAMPP/xamppfiles/htdocs/f#-tuts/Library1/Library1/test2.bin", [| 1uy |];
//               "Applications/XAMPP/xamppfiles/htdocs/f#-tuts/Library1/Library1/test3.bin", [| 1uy; 2uy |] ]

////iterate over the list of files creating each one
//List.iter File.WriteAllBytes files2

//import the File.Create function
//let create size name = File.Create(name, size, FileOptions.Encrypted)

////list of files to be created
//let names = [ "test1.bin"; "test2.bin"; "test3.bin" ]

////open the files create a list of streams
//let streams = List.map (create 1024) names

////open a file using named arguments
//let file = File.Open(path = "Applications/XAMPP/xamppfiles/htdocs/f#-tuts/Library1/Library1/test.txt",
//                       mode = FileMode.Append,
//                       access = FileAccess.Write,
//                       share = FileShare.None)

////close it!
//file.Close()

// create a FileInfo object
let file = new FileInfo("Applications/XAMPP/xamppfiles/htdocs/f#-tuts/Library1/Library1/test.txt")
// test if the file exists,
// if not create a file
if not file.Exists then
    use stream = file.CreateText()
    stream.WriteLine("hello world")
    file.Attributes <- FileAttributes.ReadOnly
// print the full file name
printfn "%s" file.FullName