

// ---------------------------------------------------------------
//         Generic classes
// ---------------------------------------------------------------

module DefiningGenericClasses =

    type StateTracker<'T>(initialElement: 'T) = // 'T is the type parameter for the class

        /// Store the states in an array
        let mutable states = [ initialElement ]

        /// Add a new element to the list of states
        member this.UpdateState newState =
            states <- newState :: states  // use the '<-' operator to mutate the value

        /// Get the entire list of historical states
        member this.History = states


        /// Get the latest state
        member this.Current = states.Head

    /// An 'int' instance of the state tracker class. Note that the type parameter is inferred.
    let tracker = StateTracker 10

    // Add a state
    tracker.UpdateState 17
