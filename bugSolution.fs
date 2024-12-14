let mutable x = 10
let mutable y = 20

let add x y = x + y

printf "%A" (add x y) // Output: 30

// Correct way to modify mutable variables if needed:
let add2 x y =
    let mutable localX = x
    let mutable localY = y
    localX <- localX + 1
    localY <- localY + 1
    localX + localY

printf "%A" (add2 x y) //Output: 32

x <- x + 1 //Modify the original mutable variable directly
y <- y + 1
printf "%A" (add x y) // Output: 34

//Better approach using immutability:
let add3 x y = (x+1) + (y+1)
printf "%A" (add3 x y) // Output: 34
printf "%A" x // Output: 11
printf "%A" y // Output: 21