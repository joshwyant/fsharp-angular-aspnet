using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Crud.Business;

namespace TestApp.Areas.Api.Controllers
{
    public class CrudController : ApiController
    {
        ICrudService service;
        public CrudController(ICrudService service)
        {
            this.service = service;
        }

        public int New(int userId, int categoryId, string description)
        {
            return service.CreateCrudItem(description, categoryId, userId);
        }

        public void Review(int id, int userId)
        {
            service.ReviewCrudItem(id, userId);
        }

        public void Complete(int id, int userId)
        {
            service.CompleteCrudItem(id, userId);
        }

        public void Cancel(int id, int userId)
        {
            service.CancelCrudItem(id, userId);
        }
    }
}
