let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printfn "%d %d" x y //this will print 20 20 as expected

//however, if we modify it to use a tuple:
let swapTuple (x,y) = 
    let (a,b) = (y,x)
    (a,b)

let (c,d) = swapTuple (x, y)
printfn "%d %d" c d //this will print 20 20 as expected

//BUT
let mutable x1 = 10
let mutable y1 = 20

let swapTupleInPlace (x, y) = 
    let temp = x
    x <- y
    y <- temp
    (x,y)

//The error is here: it doesn't swap in place
let (c1, d1) = swapTupleInPlace (x1,y1) 
printfn "%d %d" x1 y1 //this prints 10 20.  The values were not updated in place. 
printfn "%d %d" c1 d1 //this prints 20 20

//this is because the tuple is passed by value not by reference. Thus, modifications within the function do not affect the original tuple values outside.
