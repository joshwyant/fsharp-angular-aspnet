module Crud.Business.Logic
open Crud.Data
open Crud.Data.Entities
open System

type WorkflowStateIds = 
    | New = 1
    | Reviewing = 2
    | Completed = 3
    | Canceled = 4

type Crud = 
    | NewCrud of CrudItem
    | ReviewingCrud of CrudItem
    | CompletedCrud of CrudItem
    | CanceledCrud of CrudItem

    
type CrudOperations =
    static member ParseCrudItem(ci: CrudItem) =
        let state = enum<WorkflowStateIds>(ci.WorkflowStateId)
        
        match state with
        | WorkflowStateIds.New -> NewCrud(ci)
        | WorkflowStateIds.Reviewing -> ReviewingCrud(ci)
        | WorkflowStateIds.Completed -> CompletedCrud(ci)
        | WorkflowStateIds.Canceled -> CanceledCrud(ci)
        | _ -> raise (ApplicationException("Cannot parse the state for the item"))

    static member InnerCrudItem(c: Crud) =
        match c with
        | NewCrud (ci) -> ci
        | ReviewingCrud (ci) -> ci
        | CompletedCrud (ci) -> ci
        | CanceledCrud (ci) -> ci

    static member New(userId: int, category: int, description: string) =
        NewCrud(CrudItem(CreatedById = userId,
                    CategoryId = category,
                    Description = description,
                    WorkflowStateId = int WorkflowStateIds.New,
                    CreatedDate = DateTime.UtcNow))

    static member Review(crud: CrudItem, userId: int) =
        let review(ci: CrudItem) =
            ci.ReviewingById <- Nullable(userId)
            ci.ReviewingDate <- Nullable(DateTime.UtcNow)
            ci.WorkflowStateId <- int WorkflowStateIds.Reviewing
            ci
        
        match CrudOperations.ParseCrudItem(crud) with
        | NewCrud (ci) -> ReviewingCrud(review(ci))
        | _ -> raise (ApplicationException("Cannot move item to reviewing status"))

    static member Complete(crud: CrudItem, userId: int) =
        let complete(ci: CrudItem) =
            ci.CompletedById <- Nullable(userId)
            ci.CompletedDate <- Nullable(DateTime.UtcNow)
            ci.WorkflowStateId <- int WorkflowStateIds.Completed
            ci
        
        match CrudOperations.ParseCrudItem(crud) with
        | ReviewingCrud (ci) -> CompletedCrud(complete(ci))
        | _ -> raise (ApplicationException("Cannot move item to completed status"))

    static member Cancel(crud: CrudItem, userId: int) =
        let cancel(ci: CrudItem) =
            ci.CanceledById <- Nullable(userId)
            ci.CanceledDate <- Nullable(DateTime.UtcNow)
            ci.WorkflowStateId <- int WorkflowStateIds.Canceled
            ci
        
        match CrudOperations.ParseCrudItem(crud) with
        | CompletedCrud (ci) -> CanceledCrud(cancel(ci))
        | _ -> raise (ApplicationException("Cannot move item to canceled status"))