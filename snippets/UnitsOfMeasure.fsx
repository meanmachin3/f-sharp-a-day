
// ---------------------------------------------------------------
//         Units of measure
// ---------------------------------------------------------------

module UnitsOfMeasure =
    // Code can be annotated with units of measure when using F# arithmetic over numeric types

    open Microsoft.FSharp.Data.UnitSystems.SI.UnitNames

    [<Measure>]
    type mile =

        /// Conversion factor mile to meter: meter is defined in SI.UnitNames

        static member asMeter = 1600.<meter/mile>


    let d  = 50.<mile>          // Distance expressed using imperial units
    let d' = d * mile.asMeter   // Same distance expressed using metric system

    printfn "%A = %A" d d'
    // let error = d + d'       // Compile error: units of measure do not match
