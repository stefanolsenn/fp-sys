namespace ClassLibrary1
open System
open csharp_lib

module FSharpWeatherForecast =

    let genRandomNumbers count =
        let rnd = System.Random()
        List.init count (fun _ -> rnd.Next (count))
        
     
    let weatherForecast =
        genRandomNumbers 5 |> List.map (fun i ->
            let rng = System.Random()
            let s = Summaries.GetAt(rng.Next(Summaries.Count()))
            WeatherForecast.Create(DateTime.Now.AddDays((float)i), rng.Next(-20, 55), s))

module CustomerId =
    type CustomerId = private CustomerId of string
    
    let create (customerId : string) =
        match customerId with
        | null -> Error "Customer ID cannot be null."
        | ""   -> Error "Customer ID cannot be empty."
        | id when id.Length <> 10 -> Error "Invalid Customer ID."
        | _ -> Ok (CustomerId (customerId.ToLower()))