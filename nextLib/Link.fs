module Fable.Next.Link
open Fable.Core
open Fable.React.Helpers
open Fable.React
open Fable.Core.JsInterop

type LinkProps = 
  | [<CompiledName "href">] Href of string
  | [<CompiledName "as">] As of string
  | [<CompiledName "scroll">] Scroll of bool
  | [<CompiledName "shallow">] Shallow of bool
  | [<CompiledName "passHref">] PassHref of bool
  | [<CompiledName "prefetch">] Prefetch of bool
  | [<CompiledName "replace">] Replace of bool

let inline link (props: LinkProps list) (elems : ReactElement list) : ReactElement =
  ofImport "default" "next/link" (keyValueList CaseRules.LowerFirst props) elems
