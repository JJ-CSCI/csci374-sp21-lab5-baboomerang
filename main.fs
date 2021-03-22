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
    match t with
    | Node (left, right) -> map f left * map f right
    | Leaf l -> f l
    | _ -> f 0 //not sure what to do here

let rec foldStr (nf:string -> string -> string) (lf:int->string) (t:Tree) :string =
    ""
