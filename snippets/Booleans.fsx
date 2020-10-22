
// ---------------------------------------------------------------
//         Booleans
// ---------------------------------------------------------------

module SomeBooleanValues =

    let boolean1 = true

    let boolean2 = false

    let boolean3 = not boolean1 && (boolean2 || false)

    printfn "The expression 'not boolean1 && (boolean2 || false)' is %A" boolean3
