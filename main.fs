module Assignment

type Tree =
    | Node of Tree * Tree //tuple of two
    | Leaf of int

let rec prod (t:Tree) :int =
    match t with   //the concept clicked for me I think
    //| Tree * Tree -> 
    | Node (left, right) -> prod left * prod right
    | Leaf l -> l
    | _ -> 1  //identity

let rec map (f:int->int) (t:Tree) :Tree =
    t

let rec foldStr (nf:string -> string -> string) (lf:int->string) (t:Tree) :string =
    ""
