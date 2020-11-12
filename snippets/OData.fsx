// ---------------------------------------------------------------
//         OData access using type providers
// ---------------------------------------------------------------

module OData =

    (*

    open System.Data.Services.Client
    open Microsoft.FSharp.Data.TypeProviders

    // Consume demographics population and income OData service from Azure Marketplace.
    // For more information, see http://go.microsoft.com/fwlink/?LinkId=239712

    type Demographics = Microsoft.FSharp.Data.TypeProviders.ODataService<ServiceUri = "https://api.datamarket.azure.com/Esri/KeyUSDemographicsTrial/">
    let ctx = Demographics.GetDataContext()

    // Sign up for a Azure Marketplace account at https://datamarket.azure.com/account/info
    ctx.Credentials <- System.Net.NetworkCredential ("<your liveID>", "<your Azure Marketplace Key>")

    let cities =
        query { for c in ctx.demog1 do
                where (c.StateName = "Washington") }

    for c in cities do
        printfn "%A - %A" c.GeographyId c.PerCapitaIncome2010.Value

    *)

    ()