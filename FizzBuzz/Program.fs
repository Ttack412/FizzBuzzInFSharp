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
    System.Console.Write("Please Enter an Int for the FizzBuzz Program: ")
    let userInput = System.Console.ReadLine()
    System.Console.WriteLine("")

    let FizzBuzzResult = new System.Text.StringBuilder()
    for i = 1 to System.Int32.Parse(userInput) do
        FizzBuzzResult.Append((FizzBuzz i)) |> ignore
        Console.WriteLine(FizzBuzzResult)
        FizzBuzzResult.Clear() |> ignore
    0




