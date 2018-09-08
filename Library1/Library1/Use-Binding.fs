#if INTERACTIVE
#else
module UseBindings
#endif

open System.IO

// function to read first line from a file
let readFirstLine filename = 
    // open file using a "use" bind
    use file = File.OpenText filename
    file.ReadLine()

// call function and print the result
printfn "First line was: %s" (readFirstLine "/applications/xampp/htdocs/f#-tuts/Library1/Library1/sample.txt")