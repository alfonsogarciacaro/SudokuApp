module Sudoku

open System
open Fable.Core
open Fable.Import
open Fable.Import.ReactNative
open Fable.Helpers.ReactNative
open Fable.Helpers.ReactNative.Props


type Sudoku (props) =
    inherit React.Component<obj,obj>(props)

    member x.render () =
        navigator [
            InitialRoute (createRoute("Start",0))
            RenderScene (Func<_,_,_>(fun route navigator ->
                match route.id with                
                | _ ->
                    createScene<MainScene.MainScene,_,_>(
                        {
                            Navigator = navigator
                        }) 
            ))
            
        ]

        
