// ---------------------------------------------------------------
//         Recursive functions
// ---------------------------------------------------------------

module RecursiveFunctions  =

    /// Compute the factorial of an integer. Use 'let rec' to define a recursive function
    let rec factorial n =
        if n = 0 then 1 else n * factorial (n-1)

    /// Computes the greatest common factor of two integers.
    //  Since all of the recursive calls are tail calls, the compiler will turn the function into a loop,
    //  which improves performance and reduces memory consumption.

    let rec greatestCommonFactor a b =
        if a = 0 then b
        elif a < b then greatestCommonFactor a (b - a)
        else greatestCommonFactor (a - b) b

    /// Computes the sum of a list of integers using recursion.
    let rec sumList xs =
        match xs with
        | []    -> 0
        | y::ys -> y + sumList ys

    /// Make the function tail recursive, using a helper function with a result accumulator
    let rec private sumListTailRecHelper accumulator xs =
        match xs with
        | []    -> accumulator
        | y::ys -> sumListTailRecHelper (accumulator+y) ys

    let sumListTailRecursive xs = sumListTailRecHelper 0 xs
