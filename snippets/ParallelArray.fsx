

// ---------------------------------------------------------------
//         Parallel array programming
// ---------------------------------------------------------------

module ParallelArrayProgramming =

    let oneBigArray = [| 0 .. 100000 |]

    // do some CPU intensive computation
    let rec computeSomeFunction x =
        if x <= 2 then 1
        else computeSomeFunction (x - 1) + computeSomeFunction (x - 2)

    // Do a parallel map over a large input array
    let computeResults() = oneBigArray |> Array.Parallel.map (fun x -> computeSomeFunction (x % 20))

    printfn "Parallel computation results: %A" (computeResults())
