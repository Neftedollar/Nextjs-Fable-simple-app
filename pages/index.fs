module Pages.Index
open Fable.Core.JsInterop
open Fable.React

let home () =
    div [] [ str "Fable welcome Next.js" ]
home |> exportDefault