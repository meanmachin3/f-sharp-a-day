// ---------------------------------------------------------------
//         Database access using type providers
// ---------------------------------------------------------------

module DatabaseAccess =

    // The easiest way to access a SQL database from F# is to use F# type providers.
    // Add references to System.Data, System.Data.Linq, and FSharp.Data.TypeProviders.dll.
    // You can use Server Explorer to build your ConnectionString.

    (*

    #r "System.Data"
    #r "System.Data.Linq"
    #r "FSharp.Data.TypeProviders"

    open Microsoft.FSharp.Data.TypeProviders

    type SqlConnection = SqlDataConnection<ConnectionString = @"Data Source=.\sqlexpress;Initial Catalog=tempdb;Integrated Security=True">
    let db = SqlConnection.GetDataContext()

    let table =
        query { for r in db.Table do
                select r }

    *)

    // You can also use SqlEntityConnection instead of SqlDataConnection, which accesses the database using Entity Framework.

    ()
