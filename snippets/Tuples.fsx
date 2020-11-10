// ---------------------------------------------------------------
//         Tuples (ordered sets of values)
// ---------------------------------------------------------------

module Tuples =

    /// A simple tuple of integers
    let tuple1 = (1, 2, 3)

    /// A function that swaps the order of two values in a tuple.
    /// QuickInfo shows that the function is inferred to have a generic type.

    let swapElems (a, b) = (b, a)

    printfn "The result of swapping (1, 2) is %A" (swapElems (1,2))

    /// A tuple consisting of an integer, a string, and a double-precision floating point number
    let tuple2 = (1, "fred", 3.1415)

    printfn "tuple1: %A    tuple2: %A" tuple1 tuple2

