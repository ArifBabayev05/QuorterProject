using System;
using Microsoft.AspNetCore.Mvc;

namespace QuorterBackEnd.ViewComponents.Commenta
{
    public class _CommentaList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

