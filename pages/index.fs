module Pages.Index

open Fable.React
open Fable.Core
open Fable.Core.JsInterop

let inline toJsx (el: ReactElement) : JSX.Element = unbox el
let inline toReact (el: JSX.Element) : ReactElement = unbox el

/// Enables use of Feliz styles within a JSX hole
// let inline toStyle (styles: Feliz.IStyleAttribute list) : obj = JsInterop.createObj (unbox styles)

let toClass (classes: (string * bool) list) : string =
    classes
    |> List.choose (fun (c, b) ->
        match c.Trim(), b with
        | "", _
        | _, false -> None
        | c, true -> Some c)        
    |> String.concat " "

// [<JSX.Component>]
// let hello () =
//     JSX.jsx
//         $"""
//         <div>hello</div>
//     """

let home () =
    div [] [ // toReact (hello())
             str "Fable welcome Next.js. "
             br []
             str "enjoy your stay." ]
    // html $"""<my-counter initial="10"></my-counter>"""

home |> exportDefault //exportDefault is important for next js