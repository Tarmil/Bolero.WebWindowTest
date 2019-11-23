module Bolero.WebWindowTest.Client.Main

open Elmish
open Bolero
open Bolero.Html

type Model =
    {
        counter: int
    }

let initModel =
    {
        counter = 0
    }

type Message =
    | Increment
    | Decrement

let update message model =
    match message with
    | Increment -> { model with counter = model.counter + 1 }
    | Decrement -> { model with counter = model.counter - 1 }

let view model dispatch =
    concat [
        button [on.click (fun _ -> dispatch Decrement)] [text "-"]
        textf " %i " model.counter
        button [on.click (fun _ -> dispatch Increment)] [text "+"]
    ]

type MyApp() =
    inherit ProgramComponent<Model, Message>()

    override this.Program =
        Program.mkSimple (fun _ -> initModel) update view
