using System;
using Business.Concrete;
using DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace QuorterBackEnd.ViewComponents.Commenta
{
    public class _AddCommenta : ViewComponent
    {
        // CommentaManager commentaManager = new CommentaManager(new EfCommentaDal());

      // [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        }

       
    }
}

