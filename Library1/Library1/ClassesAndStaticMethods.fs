#if INTERACTIVE
#else
module ClassesAndStaticMethods
#endif
// a very crude hasher - don't
// use this method in real code!
let hash (s : string) =
  s.GetHashCode()
// pretend to get a user from a database
let getUserFromDB id =
  ((sprintf "someusername%i" id), 1234)
// a class that represents a user
// its constructor takes two parameters, the user's
// name and a hash of their password
type User(name, passwordHash) =
  // hashes the users password and checks it against
  // the known hash
  member x.Authenticate(password) =
    let hashResult = hash password
    passwordHash = hashResult
  // gets the users logon message
  member x.LogonMessage() =
    Printf.sprintf "Hello, %s" name
