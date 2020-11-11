// ---------------------------------------------------------------
//         Sequences
// ---------------------------------------------------------------

module Sequences =

    // Sequences are evaluated on-demand and are re-evaluated each time they are iterated.
    // An F# sequence is an instance of a System.Collections.Generic.IEnumerable<'T>,
    // so Seq functions can be applied to Lists and Arrays as well.

    /// The empty sequence
    let seq1 = Seq.empty

    let seq2 = seq { yield "hello"; yield "world"; yield "and"; yield "hello"; yield "world"; yield "again" }

    let numbersSeq = seq { 1 .. 1000 }

    /// another array containing only the words "hello" and "world"
    let seq3 =
        seq { for word in seq2 do
                  if word.Contains("l") then
                      yield word }

    let evenNumbers = Seq.init 1001 (fun n -> n * 2)

    let rnd = System.Random()

    /// An infinite sequence which is a random walk
    //  Use yield! to return each element of a subsequence, similar to IEnumerable.SelectMany.

    let rec randomWalk x =
        seq { yield x
              yield! randomWalk (x + rnd.NextDouble() - 0.5) }

    let first100ValuesOfRandomWalk =
        randomWalk 5.0
        |> Seq.truncate 100
        |> Seq.toList