// Learn more about F# at http://fsharp.org

open System

let FizzBuzz (myNumber:Int32):String =
    let myReturn = new System.Text.StringBuilder()
    if myNumber % 3 = 0 && myNumber % 5 = 0 then myReturn.Append("FizzBuzz") |> ignore
    elif myNumber % 3 = 0 then myReturn.Append("Fizz") |> ignore
    elif myNumber % 5 = 0 then myReturn.Append("Buzz") |> ignore
    else myReturn.Append(myNumber.ToString()) |> ignore
    myReturn.ToString()

[<EntryPoint>]
let main argv =
    let FizzBuzzResult = new System.Text.StringBuilder()
    for i = 1 to 30 do
        FizzBuzzResult.Append((FizzBuzz i)) |> ignore
        Console.WriteLine(FizzBuzzResult)
        FizzBuzzResult.Clear() |> ignore
    0




