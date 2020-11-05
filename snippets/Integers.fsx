// ---------------------------------------------------------------
//         Integers and basic functions
// ---------------------------------------------------------------

module Integers =
    let sampleInteger = 176

    /// Do some arithmetic starting with the first integer
    let sampleInteger2 = (sampleInteger/4 + 5 - 7) * 4

    /// A list of the numbers from 0 to 99
    let sampleNumbers = [ 0 .. 99 ]

    /// A list of all tuples containing all the numbers from 0 to 99 and their squares
    let sampleTableOfSquares = [ for i in 0 .. 99 -> (i, i*i) ]

    // The next line prints a list that includes tuples, using %A for generic printing
    printfn "The table of squares from 0 to 99 is:\n%A" sampleTableOfSquares
