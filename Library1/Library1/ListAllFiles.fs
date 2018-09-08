#if INTERACTIVE
#else
module ListAllFiles
#endif

open System.IO

//list all the files in the root drive
let files = Directory.GetFiles(@"Applications/XAMPP/")

//write out various information about the file
for filepath in files do
    let file = new FileInfo(filepath)
    printfn "%s\t%d\t%O" file.Name file.Length file.CreationTime
