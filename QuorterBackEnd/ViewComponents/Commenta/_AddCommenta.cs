using System;
using Microsoft.AspNetCore.Mvc;

namespace QuorterBackEnd.ViewComponents.Commenta
{
    public class _AddCommenta : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

