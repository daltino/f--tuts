#if INTERACTIVE
#else
module Fruits
#endif

//open System.Xml

////create an xml dom object
//let fruitsDoc = 
//    let temp = new XmlDocument()
//    temp.Load("/Applications/XAMPP/xamppfiles/htdocs/f#-tuts/Library1/Library1/fruits.xml")
//    temp

////select a list of nodes from the xml dom
//let fruits = fruitsDoc.SelectNodes("/fruits/*")

////print out th ename and text from each node
//for x in fruits do
//    printfn "%s = %s" x.Name x.InnerText

open System.Xml
let animals =
   [
       "ants", 6
       "spiders", 8
       "cats", 4 
   ]
// create an xml dom object
let animalsDoc = new XmlDocument()
// create the root element and append it to the doc
let rootNode = animalsDoc.CreateElement("animals")
animalsDoc.AppendChild(rootNode) |> ignore
// add each animal to the document
for animal in animals do
   let name, legs = animal
   let animalElement = animalsDoc.CreateElement(name)
   // set the leg-count as the inner text of the element
   animalElement.InnerText <- legs.ToString()
   rootNode.AppendChild(animalElement) |> ignore
// save the document
animalsDoc.Save(@"/Applications/XAMPP/xamppfiles/htdocs/f#-tuts/Library1/Library1/animals.xml")