// ---------------------------------------------------------------
//         Record types
// ---------------------------------------------------------------

module RecordTypes =
    // define a record type
    type ContactCard =
        { Name     : string
          Phone    : string
          Verified : bool }

    let contact1 = { Name = "Alf" ; Phone = "(206) 555-0157" ; Verified = false }

    // Create a new record that is a copy of contact1,
    // but has different values for the 'Phone' and 'Verified' fields

    let contact2 = { contact1 with Phone = "(206) 555-0112"; Verified = true }

    /// Converts a 'ContactCard' object to a string
    let showCard c =
        c.Name + " Phone: " + c.Phone + (if not c.Verified then " (unverified)" else "")
