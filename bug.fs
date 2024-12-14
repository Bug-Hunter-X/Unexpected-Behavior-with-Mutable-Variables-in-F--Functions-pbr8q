let mutable x = 10
let mutable y = 20

let add x y = x + y

printf "%A" (add x y)

//Trying to change the value of x and y within the function
let add2 x y =
    x <- x + 1
    y <- y + 1
    x + y

printf "%A" (add2 x y)