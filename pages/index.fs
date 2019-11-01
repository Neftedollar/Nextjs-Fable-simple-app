module Pages.Index
open Fable.Core.JsInterop
open Fable.React

// [<Global>]
let home () =
    div [] [ str "Welcome to Fable Next.js" ]
home |> exportDefault