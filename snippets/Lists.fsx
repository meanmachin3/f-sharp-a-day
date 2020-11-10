// ---------------------------------------------------------------
//         Lists and list processing
// ---------------------------------------------------------------

module Lists =

    let list1 = [ ]            /// an empty list

    let list2 = [ 1; 2; 3 ]    /// list of 3 elements

    let list3 = 42 :: list2    /// a new list with '42' added to the beginning

    let numberList = [ 1 .. 1000 ]  /// list of integers from 1 to 1000

    /// A list containing all the days of the year
    let daysList =
        [ for month in 1 .. 12 do
              for day in 1 .. System.DateTime.DaysInMonth(2012, month) do
                  yield System.DateTime(2012, month, day) ]

    /// A list containing the tuples which are the coordinates of the black squares on a chess board.
    let blackSquares =

        [ for i in 0 .. 7 do
              for j in 0 .. 7 do
                  if (i+j) % 2 = 1 then
                      yield (i, j) ]

    /// Square the numbers in numberList, using the pipeline operator to pass an argument to List.map
    let squares =
        numberList
        |> List.map (fun x -> x*x)

    /// Computes the sum of the squares of the numbers divisible by 3.
    let sumOfSquaresUpTo n =
        numberList
        |> List.filter (fun x -> x % 3 = 0)
        |> List.sumBy (fun x -> x * x)