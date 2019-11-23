namespace Bolero.WebWindowTest.Client

open Microsoft.AspNetCore.Components.Builder
open Microsoft.Extensions.DependencyInjection

type Startup() =

    member __.ConfigureServices(services: IServiceCollection) =
        ()

    member __.Configure(app: IComponentsApplicationBuilder) =
        app.AddComponent<Main.MyApp>("#main")

module Program =
    open WebWindows.Blazor

    [<EntryPoint>]
    let Main args =
        ComponentsDesktop.Run<Startup>("My Bolero app", "wwwroot/index.html")
        0
