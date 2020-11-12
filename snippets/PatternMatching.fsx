
// ---------------------------------------------------------------
//         Pattern matching
// ---------------------------------------------------------------

module PatternMatching =

    /// A record for a person's first and last name

    type Person =
        { First : string
          Last  : string }

    /// Define a discriminated union of 3 different kinds of employees

    type Employee =
        /// Engineer is just herself
        | Engineer  of Person
        /// Manager has list of reports
        | Manager   of Person * list<Employee>
        /// Executive also has an assistant
        | Executive of Person * list<Employee> * Employee

    /// Count everyone underneath the employee in the management hierarchy, including the employee
    let rec countReports(emp : Employee) =
        1 + match emp with
            | Engineer(id) ->
                0
            | Manager(id, reports) ->
                reports |> List.sumBy countReports
            | Executive(id, reports, assistant) ->
                (reports |> List.sumBy countReports) + countReports assistant

    /// Find all managers/executives named "Dave" who do not have any reports
    let rec findDaveWithOpenPosition(emps : Employee list) =
        emps
        |> List.filter(function
                       | Manager({First = "Dave"}, []) -> true       // [] matches the empty list
                       | Executive({First = "Dave"}, [], _) -> true
                       | _ -> false)                                 // '_' is a wildcard pattern that matches anything
                                                                     // this handles the "or else" case
