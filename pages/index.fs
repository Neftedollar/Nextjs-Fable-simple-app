module Pages.Index

open Fable.Core
open Fable.Core.JsInterop

let home () =
    JSX.jsx
        $"""
    <div>
        <p>Hello World</p>
    </div>
    """

home |> exportDefault //exportDefault is important for next js