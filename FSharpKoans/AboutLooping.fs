﻿namespace FSharpKoans
open FSharpKoans.Core

//---------------------------------------------------------------
// About Looping
//
// While it's more common in F# to use the Seq, List, or Array
// modules to perform looping operations, you can still fall 
// back on traditional imperative looping techniques that you may 
// be more familiar with.
//---------------------------------------------------------------
type ``about looping``() =
    [<Koan>]
    member this.LoopingOverAList() =
        let values = [0..10]

        let mutable sum = 0
        for value in values do
            sum <- sum + value

        AssertEquality sum __
       
    [<Koan>]
    member this.LoopingWithExpressions() =
        let mutable sum = 0

        for i = 1 to 5 do
            sum <- sum + i

        AssertEquality sum __

    [<Koan>]
    member this.LoopingWithWhile() =
        let mutable sum = 1

        while sum < 10 do
            sum <- sum + sum

        AssertEquality sum __

    (* NOTE: While these looping constructs can come in handy from time to time,
             it's often better to use a more functional approach for looping
             such as the functions you learned about in the List module. *)