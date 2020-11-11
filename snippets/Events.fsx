// ---------------------------------------------------------------
//         Using events
// ---------------------------------------------------------------

module Events =

    open System

    // Create instance of Event object that consists of subscription point (event.Publish) and event trigger (event.Trigger)
    let simpleEvent = new Event<int>()

    // Add handler
    simpleEvent.Publish.Add(fun x -> printfn "this is handler was added with Publish.Add: %d" x)

    // Trigger event
    simpleEvent.Trigger(5)

    // Create instance of Event that follows standard .NET convention: (sender, EventArgs)
    let eventForDelegateType = new Event<EventHandler, EventArgs>()


    // Add handler
    eventForDelegateType.Publish.AddHandler(
        EventHandler(fun _ _ -> printfn "this is handler was added with Publish.AddHandler"))


    // Trigger event (note that sender argument should be set)
    eventForDelegateType.Trigger(null, EventArgs.Empty)