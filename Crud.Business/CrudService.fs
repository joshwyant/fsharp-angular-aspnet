namespace Crud.Business

open System
open Crud.Data.Contracts
open Crud.Data.Entities
open Crud.Business.Logic

type ICrudService =
    abstract member CreateCrudItem:  description:string -> categoryId:int -> userId:int -> int
    abstract member ReviewCrudItem: id:int -> userId:int -> unit
    abstract member CompleteCrudItem: id:int -> userId:int -> unit
    abstract member CancelCrudItem: id:int -> userId:int -> unit

type CrudService(unitOfWork: ICrudUnitOfWork) = 
    interface ICrudService with

        member this.CreateCrudItem description categoryId userId =
            let mutable crudItem = CrudOperations.InnerCrudItem(CrudOperations.New(userId, categoryId, description))
            unitOfWork.CrudItems.Add(crudItem)
            unitOfWork.SaveChanges() |> ignore
            crudItem.Id

        member this.ReviewCrudItem id userId =
            CrudOperations.Review(unitOfWork.CrudItems.Find(id), userId) |> ignore
            unitOfWork.SaveChanges() |> ignore

        member this.CompleteCrudItem id userId =
            CrudOperations.Complete(unitOfWork.CrudItems.Find(id), userId) |> ignore
            unitOfWork.SaveChanges() |> ignore

        member this.CancelCrudItem id userId =
            CrudOperations.Cancel(unitOfWork.CrudItems.Find(id), userId) |> ignore
            unitOfWork.SaveChanges() |> ignore

