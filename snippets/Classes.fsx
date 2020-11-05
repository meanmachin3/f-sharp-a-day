// ---------------------------------------------------------------
//         Classes
// ---------------------------------------------------------------

module DefiningClasses =
    /// The class's constructor takes two arguments: dx and dy, both of type 'float'.
    type Vector2D(dx : float, dy : float) =

        /// The length of the vector, computed when the object is constructed
        let length = sqrt (dx*dx + dy*dy)

        // 'this' specifies a name for the object's self identifier
        // In instance methods, it must appear before the member name.

        member this.DX = dx

        member this.DY = dy

        member this.Length = length

        member this.Scale(k) = Vector2D(k * this.DX, k * this.DY)


    /// An instance of the Vector2D class
    let vector1 = Vector2D(3.0, 4.0)

    /// Get a new scaled vector object, without modifying the original object
    let vector2 = vector1.Scale(10.0)

    printfn "Length of vector1: %f      Length of vector2: %f" vector1.Length vector2.Length
