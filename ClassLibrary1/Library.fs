namespace FSharp_lib

module Customer =
    open System.Collections.Generic

    type Customer =
        struct
            val mutable id: string
            val mutable name: string
        end
    
    let create (customerId : string, customerName: string) =
        match customerId, customerName  with
        | null, null -> Error "Customer ID and customer name cannot be null."
        | "", ""   -> Error "Customer ID and Customer name cannot be empty."
        | null, "" -> Error "Customer ID cannot be null, and customer name cannot be empty"
        | "", null -> Error "Customer ID is empty, customer name is null"
        | id, _ when id.Length <> 10 -> Error "ID should have a length of 10"
        | _, name when name.Length <= 0 -> Error "Name should have a length over 0"
        | _ -> Ok (Customer(id = customerId, name = customerName))
        
    let createMany max =
        let list = new List<Customer>()
        for i = 0 to max-1 do
            list.Add(Customer(id = "1234567890", name = "Stefan Olsen"))
        list.ToArray
