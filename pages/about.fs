module Pages.About

open Fable.Core.JsInterop
open Fable.React
open Fable.Next
open Components.Header

let idPostLinks text = 
  p [] [ Link.link [ Link.Href "/p/[id]" ; Link.As <| sprintf "%s" text ] [ str text ] ]

let about () =
  div [] [ 
    Header ()
    p [] [str "About page"]
  ]
about |> exportDefault //export