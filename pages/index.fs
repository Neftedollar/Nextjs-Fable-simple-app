module Pages.Index
open Fable.Core.JsInterop
open Fable.React
open Fable.Next
open Components.Header

let postLink text= 
  p [] [ Link.link [ Link.Href <| sprintf "/post?title=%s" text ] [ str text ] ]

let home () =
    div [] [ 
      Header ()
      postLink "Hello Next.js + Fable"
      postLink "Learn Next.js is awesome"
      postLink "Deploy apps with Zeit" 
      p [] [str "Fable welcome Next.js"]
    ]
home |> exportDefault //exportDefault is important for next js