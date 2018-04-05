open System
//open System.Security.Cryptography.X509Certificates

// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
let do_funcs() = 
    
    let cube x =
        x * x * x
    printfn "Enter an integer value you would like to have cubed:"
    let result = (cube 4)
    printfn "Cube of 4 : %i" result

    let thrd list =
        List.item(2) list
    let list = [ 1; 2; 3; 4; 5 ]
    let result = (thrd list)
    printfn "The third element in the list is: %i" result

    let min3 (x:int) (y:int) (z:int) = 
        if x < y && x<z then  x
        else if y < x && y<z then y
        else z
        
    let result = (min3 2 3 1)
    printfn "The minimum value is: %i" result

    let del2nd list =
        let (newList:List<int>) = List.tail list
        let finalList =List.append [(List.head list)]  newList.Tail
        finalList
    let list = [ 1; 2; 3; 4; 5]
    let result = (del2nd list)
    printfn "The new list is: %A" result

    let cycle1 list = 
        let firstElement = List.item(0) list
        let newList = List.tail list
        let finalList = List.append newList [firstElement]
        finalList
    let result = (cycle1 [1; 2; 3; 4; 5])
    printfn "The new list is: %A" result

    let rec rotate (n:int) list = 
        let i = n
        let firstElement = List.item(0) list
        let newList = List.tail list
        let finalList = List.append newList [firstElement]
        if i = 1 then finalList
        else (rotate (n-1) finalList)
            
    let result = (rotate 3 [1; 2; 3; 4; 5])
    printfn "The new list is: %A" result

    let isMember n list = 
        let i = 0
        let rec isMemberRec n list i =
            if List.item i list = n then true
            else (isMemberRec n list (i+1))
        (isMemberRec n list i)
    let result = (isMember 3 [1; 2; 3; 4; 5])
    printfn "The new list is: %A" result

    //let countMatches func list =

do_funcs()
Console.ReadKey() |> ignore
