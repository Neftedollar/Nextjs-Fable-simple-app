module Components.Header
open Fable.Core.JsInterop
open Fable.React
open Fable.Next.Link
// open Fable.React.Helpers
let style : Props.IHTMLProp list = [ Props.Style [ Props.MarginRight 15 ] ]
let Header () =
  div [] [
    link [Href "/"] [ a style [str "Home"]]
    link [Href "/about"] [  a style [str "About"] ]
  ]