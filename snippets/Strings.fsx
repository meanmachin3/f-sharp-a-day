// ---------------------------------------------------------------
//         Strings
// ---------------------------------------------------------------

module StringManipulation =

    let string1 = "Hello"

    let string2  = "world"

    /// Use @ to create a verbatim string literal

    let string3 = @"c:\Program Files\"

    /// Using a triple-quote string literal
    let string4 = """He said "hello world" after you did"""

    let helloWorld = string1 + " " + string2 // concatenate the two strings with a space in between

    printfn "%s" helloWorld

    /// A string formed by taking the first 7 characters of one of the result strings
    let substring = helloWorld.[0..6]

    printfn "%s" substring
