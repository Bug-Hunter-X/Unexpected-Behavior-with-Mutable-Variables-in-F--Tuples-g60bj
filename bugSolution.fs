let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printfn "%d %d" x y //this will print 20 20 as expected

//The correct way to solve the problem of swapping mutable variables:
let swapInPlace (xRef:byref<int>) (yRef:byref<int>) = 
    let temp = xRef
    xRef <- yRef
    yRef <- temp

let mutable x1 = 10
let mutable y1 = 20

swapInPlace &x1 &y1 //Note the use of the & operator to pass by reference
printfn "%d %d" x1 y1 //This will now correctly print 20 10

//Alternative solution using a different data structure:
let swapList list = 
    let mutable listRef = list
    let temp = listRef.[0]
    listRef.[0] <- listRef.[1]
    listRef.[1] <- temp
    listRef

let mutable myList = [|10;20|]
let swappedList = swapList myList
printfn "%A" swappedList // prints [|20; 10|] 
printfn "%A" myList // prints [|20; 10|]

//Note: for tuples and in-place modification you should avoid tuples as parameters. Consider using a different approach, like the `byref` approach shown above for individual variables or alternative data structures that support mutable updates within the function like lists or arrays.
