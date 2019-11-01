module Fable.Next.Router
open Fable.Core
open Fable.React.Helpers
open Fable.React
open Fable.Core.JsInterop


type [<AllowNullLiteral>] ParsedUrlQuery =
  [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> string with get, set

type [<AllowNullLiteral>] BaseRouter =
  abstract route: string with get, set
  abstract pathname: string with get, set
  abstract query: ParsedUrlQuery with get, set
  abstract asPath: string with get, set

let useRouter () = import<BaseRouter> "useRouter" "next/router"