// ---------------------------------------------------------------
//         Option types
// ---------------------------------------------------------------

module OptionTypes =
    /// Option values are any kind of value tagged with either 'Some' or 'None'.
    /// They are used extensively in F# code to represent the cases where many other
    /// languages would use null references.

    type Customer = { ZipCode : decimal option }

    /// Abstract class that computes the shipping zone for the customer's zip code,
    /// given implementations for the 'GetState' and 'GetShippingZone' abstract methods.

    [<AbstractClass>]

    type ShippingCalculator =

        abstract GetState : decimal -> string option

        abstract GetShippingZone : string -> int

        /// Return the shipping zone corresponding to the customer's ZIP code
        /// Customer may not yet have a ZIP code or the ZIP code may be invalid
        member this.CustomerShippingZone(customer : Customer) =

            customer.ZipCode
            |> Option.bind this.GetState
            |> Option.map this.GetShippingZone

