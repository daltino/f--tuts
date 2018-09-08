#if INTERACTIVE
#else
module Classes
#endif

//a very crude hasher - don't use this method in real code!
let hash (s:string) = s.GetHashCode()

////a class that represents a user its constructor takes two parameters,
////the user's name and a hash of their password
//type User(name, passwordHash) = 
//    //hashes the users password and checks it against the known hash
//    member x.Authenticate(password) = 
//        let hashResult = hash password
//        passwordHash = hashResult

//    //gets the users logon message
//    member x.LogonMessage() = 
//        sprintf "Hello, %s" name

////Create a user using the primary constructor
//let user1 = User("kiteason",1234)
////access a method of the User instance
//printfn "*** %s" (user1.LogonMessage())

//// a class that represents a user
//// its constructor takes three parameters, the user's
//// first name, last name and a hash of their password
//type User(firstName, lastName, passwordHash) =
//     // calculate the user's full name and store of later use
//     let fullName = Printf.sprintf "%s %s" firstName lastName
//     // print users fullname as object is being constructed
//     do printfn "User: %s" fullName
//     // hashes the users password and checks it against
//     // the known hash
//     member x.Authenticate(password) =
//        let hashResult = hash password
//        passwordHash = hashResult
//     // retrieves the users full name
//     member x.GetFullname() = fullName

//// a class that represents a user
//// its constructor takes two parameters, the user's
//// name and a hash of their password
//type User(name, passwordHash) =
//     // hashes the users password and checks it against
//     // the known hash
//     member x.Authenticate(password) =
//        let hashResult = hash password
//        passwordHash = hashResult
//     // gets the user's logon message
//     member x.LogonMessage() =
//        Printf.sprintf "Hello, %s" name
//     // creates a copy of the user with the password changed
//     member x.ChangePassword(password) =
//        new User(name, hash password)

// a class that represents a user
// its constructor takes two parameters, the user's
// name and a hash of their password
type User(name, passwordHash) =
     // store the password hash in a mutable let
     // binding, so it can be changed later
     let mutable passwordHash = passwordHash
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