
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Hosting
open Sample.Worker
               
[<EntryPoint>]
let main argv =

    async {
        let host = Host.CreateDefaultBuilder(argv).ConfigureServices (fun hostContext services ->
            services.AddHostedService<Worker>() |> ignore )
        
        host.Build().Run() 

    } |> Async.RunSynchronously

    0


        
        
