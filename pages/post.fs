module Pages.Post
open Fable.Core.JsInterop
open Fable.React
open Fable.Next
open Components.Header

let post () = 
  let router = Router.useRouter()
  div [] [
    Header ()
    h1 [] [ str (router.query.Item "title") ]
    p [] [ str "This is the blog post content." ]
]

exportDefault post