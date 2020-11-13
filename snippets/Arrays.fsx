
// ---------------------------------------------------------------
//         Arrays
// ---------------------------------------------------------------

module Arrays =

    /// The empty array
    let array1 = [| |]

    let array2 = [| "hello"; "world"; "and"; "hello"; "world"; "again" |]

    let array3 = [| 1 .. 1000 |]

    /// An array containing only the words "hello" and "world"

    let array4 = [| for word in array2 do
                        if word.Contains("l") then
                            yield word |]

    /// An array initialized by index and containing the even numbers from 0 to 2000
    let evenNumbers = Array.init 1001 (fun n -> n * 2)

    /// sub-array extracted using slicing notation
    let evenNumbersSlice = evenNumbers.[0..500]

    for word in array4 do
        printfn "word: %s" word

    // modify an array element using the left arrow assignment operator
    array2.[1] <- "WORLD!"

    /// Calculates the sum of the lengths of the words that start with 'h'
    let sumOfLengthsOfWords =
        array2
        |> Array.filter (fun x -> x.StartsWith "h")
        |> Array.sumBy (fun x -> x.Length)
