#if INTERACTIVE
#else
module OptionalParameters
#endif

//a very crude hasher - don't use this method in real code!
let hash (s:string) = s.GetHashCode()

//type AClass(?someState:int) =
//     let state =
//        match someState with
//        | Some x -> string x
//        | None -> "<no input>"
//     member x.PrintState (prefix, ?postfix) =
//        match postfix with
//        | Some x -> printfn "%s %s %s" prefix state x
//        | None -> printfn "%s %s" prefix state
//let aClass = new AClass()
//let aClass' = new AClass(109)
//aClass.PrintState("There was ")
//aClass'.PrintState("Input was:", ", which is nice.")


// a class that represents a user
// its constructor takes two parameters, the user's
// name and a hash of their password
type User(name, passwordHash) =
     // store the password hash in a mutable let
     // binding, so it can be changed later
     let mutable passwordHash = passwordHash
     // additional constructor to create a user given the
     // raw password
     new(name : string, password : string) =
         User(name, (hash password))

     // hashes the users password and checks it against
     // the known hash
     member x.Authenticate(password) =
        let hashResult = hash password
        passwordHash = hashResult
     // gets the users logon message
     member x.LogonMessage() =
        Printf.sprintf "Hello, %s" name
     // changes the users password
     member x.ChangePassword(password) =
        passwordHash <- hash password