namespace Sample.Worker

open System
open System.Threading
open System.Threading.Tasks
open Microsoft.Extensions.Hosting
open Microsoft.Extensions.Logging

type Worker(logger:ILogger<Worker>) =
    inherit BackgroundService()

    override this.ExecuteAsync(stoppingToken:CancellationToken) =
        async {
            while not stoppingToken.IsCancellationRequested do
                logger.LogInformation (sprintf "Worker running at: %A" DateTimeOffset.Now)
                do! Async.Sleep(1000)
        }   |> Async.StartAsTask :> Task
