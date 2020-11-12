// ---------------------------------------------------------------
//         Implementing interfaces
// ---------------------------------------------------------------

/// Type that implements IDisposable

type ReadFile() =

    let file = new System.IO.StreamReader("readme.txt")

    member this.ReadLine() = file.ReadLine()

    // this class's implementation of IDisposable members
    interface System.IDisposable with
        member this.Dispose() = file.Close()
